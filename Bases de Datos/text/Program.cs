/*
* Author: Juan Soledad
* Date: 21/08/2021 
*/
using System;
using System.IO;

namespace text
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            String name;
            do
            {
                Console.Clear();
                Console.WriteLine("--Archivos de texto--");
                Console.WriteLine("Acciones:");
                Console.WriteLine("1. Crear archivo.");
                Console.WriteLine("2. Leer contenido.");
                Console.WriteLine("3. Editar archivo.");
                Console.WriteLine("4. Borrar archivo.");
                Console.WriteLine("5. Salir.");
                Console.Write("Ingrese su opción: ");
                String op = Console.ReadLine();
                
                Console.WriteLine();
                if(Int32.TryParse(op, out opcion)){
                    switch (opcion)
                    {
                        case 1: 
                            Console.WriteLine("> Crear Archivo"); 
                            Console.Write("Ingrese el nombre del archivo(sin extensión): "); 
                            name = Console.ReadLine();
                            CrearArchivo(name);
                            break;
                        case 2: 
                            Console.WriteLine("> Leer Archivo"); 
                            Console.Write("Ingrese el nombre del archivo(sin extensión): "); 
                            name = Console.ReadLine();
                            LeerArchivo(name);
                            break;
                        case 3: 
                            Console.WriteLine("> Editar Archivo"); 
                            Console.Write("Ingrese el nombre del archivo(sin extensión): "); 
                            name = Console.ReadLine();
                            EditarArchivo(name);
                            break;
                        case 4:
                            Console.WriteLine("> Borrar Archivo"); 
                            Console.Write("Ingrese el nombre del archivo(sin extensión): "); 
                            name = Console.ReadLine();
                            bool deleted = BorrarArchivo(name);
                            Console.WriteLine();
                            if (deleted)
                            {
                                Console.WriteLine("Archivo " + name + ".txt eliminado."); 
                            }else{
                                Console.WriteLine("El archivo no existe."); 
                            }
                            break;
                        case 5: Console.WriteLine("saliendo..."); break;
                        default:
                        Console.WriteLine("Opcion no valida.");
                            break;
                    }
                } else {
                    Console.WriteLine("Opcion no valida.");
                }
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine();
                
            } while (opcion != 5);
        }

        public static void CrearArchivo(String name) {
            String fileName = @"./" + name + ".txt";
            try
            {
                if(File.Exists(fileName)){
                    Console.WriteLine();
                    char op;
                    bool can_supply = false;
                    do
                    {
                        Console.Write("El archivo ya existe, ¿desea sobreescribirlo? (Y/N): ");
                        op = char.Parse(Console.ReadLine());
                        if(op == 'Y'){
                            can_supply = true;
                        }else if(op == 'N'){
                            can_supply = true;
                        }else {
                            can_supply = false;
                        }
                    } while (!can_supply);
                    if (op == 'Y')
                    {
                      bool deleted = BorrarArchivo(name);
                     
                     if (deleted)
                     {
                         FileStream fs = File.Create(fileName);
                         Console.WriteLine();
                         Console.WriteLine("Archivo " + name + ".txt sobreescrito con éxito");
                     }
                    } else {

                    }
                } else {
                    FileStream fs = File.Create(fileName);
                    Console.WriteLine("Archivo " + name + ".txt creado" );
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public static void LeerArchivo(String name) {
            String fileName = @"./" + name + ".txt";
            try
            {
                if (File.Exists(fileName))
                {
                    bool has_content = false;
                    Console.WriteLine();
                    Console.WriteLine("El archivo contiene: ");
                    using (StreamReader sr = File.OpenText(fileName))    
                    {    
                        string contenido = "";    
                        while ((contenido = sr.ReadLine()) != null)
                        {    
                            Console.WriteLine(contenido);
                            has_content = true;
                        }
                        if(!has_content){
                            Console.WriteLine("El archivo está vacío.");
                        }
                    }
                    
                    Console.WriteLine();
                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadKey();
                }else {
                    Console.WriteLine();
                    Console.WriteLine("El archivo no existe.");
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public static void EditarArchivo(String name){
            String fileName = @"./" + name + ".txt";
            try
            {
                if(File.Exists(fileName)){
                    bool has_content = false;
                    using (StreamReader sr = File.OpenText(fileName))    
                    {    
                        string contenido = "";    
                        while ((contenido = sr.ReadLine()) != null)    
                        {    
                            has_content = true;
                        }    
                    }

                    if(has_content)
                    {
                        Console.WriteLine("¿Que desea hacer con el contenido?");
                        Console.WriteLine("1. Agregar lineas.");
                        Console.WriteLine("2. Sobreescribir todo.");
                        bool op_invalid = false;
                        do
                        {
                            Console.Write("Ingrese su opción: ");
                            String op = Console.ReadLine();
                            int opc = 0;              
                            if(Int32.TryParse(op, out opc)){
                                op_invalid = false;
                                if (opc == 1){
                                    Console.WriteLine();
                                    Console.WriteLine("Usted seleccionó: escribir lineas ->");
                                    EscribirEnArchivo(fileName);
                                } else if (opc == 2){
                                    Console.WriteLine();
                                    Console.WriteLine("Usted seleccionó: sobreescribir ->");
                                    EscribirEnArchivo(fileName, true);
                                } else {
                                    op_invalid = true;
                                }
                                
                            }else{
                                op_invalid = true;
                            }
                            
                        } while (op_invalid);
                    } else {
                        EscribirEnArchivo(fileName);
                    }
                }else {
                    Console.WriteLine();
                    Console.WriteLine("El archivo no existe.");
                }
            }
            catch (System.Exception ex)
            {
                 Console.WriteLine(ex);
            }
        }
        public static bool BorrarArchivo(String name){
            String fileName = @"./" + name + ".txt";
            bool estatus = false;
            try
            {
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                    estatus = true;
                }else {
                    estatus = false;
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
                estatus = false;
            }
            return estatus;
        }

        public static void EscribirEnArchivo(String fileName, bool overwrite = false){
            if(overwrite){
                File.WriteAllText(fileName, "");
            }
            using (FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write))
            using (StreamWriter sw = new StreamWriter(fs)) { 
                String[] content = new String[1000];
                int line = 0;
                bool end_writing = false;
                Console.WriteLine("Ingrese el texto(para terminar de escribir presione dos veces Enter):");
                do
                {
                    String text_line = Console.ReadLine();
                    content[line] = text_line;
                    if(!content[line].Equals("")){
                        sw.WriteLine(content[line]);
                    }
                    if(line == 0 && content[0].Equals("")){
                        end_writing = true;
                    }else{
                        if ((line > 1) && (content[line].Equals("")) && (content[line-1].Equals("")))
                        {
                            end_writing = true;
                        }
                    }

                    line++;
                } while (!end_writing);
                sw.Close();
                fs.Close();
            }
        }
    }
}
