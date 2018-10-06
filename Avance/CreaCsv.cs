using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avance
{
    class CreaCsv
    {
        public const int TOTALRETOSCURSO2 = 158;
        public string seccion = null;

        private StreamWriter sw;
        private string[] letras = { "" };

        private string[] letrasC = { "", "C", "D","E", "F", "G","H", "I", "J", "K", "L", "M", "N", "O", "P", "Q",
            "R", "S", "T", "U", "V", "W", "X", "Y", "Z","AA", "AB", "AC","AD", "AE", "AF", "AG"};
        private string[] letrasB = { "", "C", "D","E", "F", "G","H", "I", "J", "K", "L", "M", "N", "O", "P", "Q",
            "R", "S", "T", "U", "V", "W", "X", "Y", "Z","AA", "AB", "AC","AD", "AE", "AF", "AG","AH","AI","AJ"};
        private string[] letrasA = { "", "C", "D","E", "F", "G","H", "I", "J", "K", "L", "M", "N", "O", "P", "Q",
            "R", "S", "T", "U", "V", "W", "X", "Y", "Z","AA", "AB", "AC","AD", "AE", "AF", "AG","AH","AI","AJ","AK"};

        private int cantidadEstudiantes = 31, numLineasEscritas = 0;

        public CreaCsv(string seccion)
        {
            this.seccion = seccion;
        }

        public void CreaFileCsv(Dictionary<string, Persona> grupo)
        {
            string path = @"c:\temp\Seccion" + seccion + ".csv";
            try
            {
                if (File.Exists(path))
                    File.Delete(path);
                
                //Pass the filepath and filename to the StreamWriter Constructor
                sw = new StreamWriter(path, true, Encoding.ASCII);

                switch (seccion)
                {
                    case "A":
                        letras = letrasA;
                        break;
                    case "B":
                        letras = letrasB;
                        break;
                    case "C":
                        letras = letrasC;
                        break;
                }

                //Escribe encabezados()
                EscribeEncabezados(grupo);
                //EscribeAvance
                EscribeAvance(grupo);
                //Escribe Pie
                EscribePie(grupo);
                //Close the file
                sw.Close();
            }
            catch (Exception t)
            {
                Console.WriteLine("Exception: " + t.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

        private void EscribeEncabezados(Dictionary<string, Persona> grupo)
        {
            string linea = "";
            int estudiante = 0, i = 1;

            sw.WriteLine("RANGO,A1:AG163,FECHA_SESION,06 - 04 - 2017,SESION_NUM,1,RANGO_ETAPA,A6:A163,RANGO_ALUMNOS,C3: AG5,ESCUELA, Ciudad de Los Muchachos");
            sw.WriteLine("SECCION,CM-6C-MAR-2017,CURSO 2,RANGO_ALUMNOS,C5:AG5,RANGO_RETO,A6:B163,PAIS,Venezuela");
            
            while (i <= cantidadEstudiantes)
            {
                string letra = letras[i];
                linea = linea + "," + "= CONTAR.SI(" + letra + "6: " + letra + "163;\"level_link perfect\")+CONTAR.SI(" + letra + "6: " + letra + "163;\"level_link passed\") +CONTAR.SI(" + letra + "6: " + letra + "161; \"level_link passed paired\") +CONTAR.SI(" + letra + "6: " + letra + "163; \"level_link perfect paired\")";
                i++;
            }
            linea = "OBJETIVOS,156" + linea;
            sw.WriteLine(linea);
            linea = "";
            i = 1;
            while (i <= cantidadEstudiantes)
            {
                string letra = letras[i];
                linea = linea + "," + "=SUMA("+letra+"165;"+letra+"166)";
                i++;
            }
            linea = "TOTALES,=SUMA(C4:AG4)" + linea;
            sw.WriteLine(linea);
            linea = "ETAPA,RETO";

            while (estudiante < grupo.Count())
            {
                var item = grupo.ElementAt(estudiante);
                linea = linea + "," + item.Value.getName();
                estudiante++;
            }
            sw.WriteLine(linea);
        }

        private void EscribeAvance(Dictionary<string, Persona> grupo)
        {
            int estudiante = 0, etapa = 1, reto = 1,limite = 0;
            LevelAdvance nivel = LevelAdvance.Attempted;

            while (etapa <= 19)
            {
                string linea,stage;

                stage = etapa.ToString();
                switch (etapa)
                {
                    case 1: limite = 3; break;
                    case 2: limite = 3; break;
                    case 3: limite = 11; break;
                    case 4: limite = 12; break;
                    case 5: limite = 2; break;
                    case 6: limite = 14; break;
                    case 7: limite = 16; break;
                    case 8: limite = 14; break;
                    case 9: limite = 3; break;
                    case 10: limite = 11; break;
                    case 11: limite = 12; break;
                    case 12: limite = 2; break;
                    case 13: limite = 15; break;
                    case 14: limite = 2; break;
                    case 15: limite = 2; break;
                    case 16: limite = 10; break;
                    case 17: limite = 11; break;
                    case 18: limite = 2; break;
                    case 19: limite = 13; break;
                }
                while (reto <= limite)
                {
                    linea = stage + "," + reto.ToString();
                    while (estudiante < grupo.Count())
                    {
                        var item = grupo.ElementAt(estudiante);
                        nivel = LevelAdvance.NotTried;
                        switch (etapa)
                        {
                            case 1:
                                    switch (reto)
                                    {
                                        case 1:
                                            nivel = item.Value.getE1R1(); break;
                                        case 2:
                                            nivel = item.Value.getE1R2(); break;
                                        case 3:
                                            nivel = item.Value.getE1R3(); break;
                                    }
                                break;
                            case 2:
                                switch (reto)
                                {
                                    case 1:
                                        nivel = item.Value.getE2R1(); break;
                                    case 2:
                                        nivel = item.Value.getE2R2(); break;
                                    case 3:
                                        nivel = item.Value.getE2R3(); break;
                                }
                                break;
                            case 3:
                                switch (reto)
                                {
                                    case 1:
                                        nivel = item.Value.getE3R1(); break;
                                    case 2:
                                        nivel = item.Value.getE3R2(); break;
                                    case 3:
                                        nivel = item.Value.getE3R3(); break;
                                    case 4:
                                        nivel = item.Value.getE3R4(); break;
                                    case 5:
                                        nivel = item.Value.getE3R5(); break;
                                    case 6:
                                        nivel = item.Value.getE3R6(); break;
                                    case 7:
                                        nivel = item.Value.getE3R7(); break;
                                    case 8:
                                        nivel = item.Value.getE3R8(); break;
                                    case 9:
                                        nivel = item.Value.getE3R9(); break;
                                    case 10:
                                        nivel = item.Value.getE3R10(); break;
                                    case 11:
                                        nivel = item.Value.getE3R11(); break;
                                }
                                break;
                            case 4:
                                switch (reto)
                                {
                                    case 1:
                                        nivel = item.Value.getE4R1(); break;
                                    case 2:
                                        nivel = item.Value.getE4R2(); break;
                                    case 3:
                                        nivel = item.Value.getE4R3(); break;
                                    case 4:
                                        nivel = item.Value.getE4R4(); break;
                                    case 5:
                                        nivel = item.Value.getE4R5(); break;
                                    case 6:
                                        nivel = item.Value.getE4R6(); break;
                                    case 7:
                                        nivel = item.Value.getE4R7(); break;
                                    case 8:
                                        nivel = item.Value.getE4R8(); break;
                                    case 9:
                                        nivel = item.Value.getE4R9(); break;
                                    case 10:
                                        nivel = item.Value.getE4R10(); break;
                                    case 11:
                                        nivel = item.Value.getE4R11(); break;
                                    case 12:
                                        nivel = item.Value.getE4R12(); break;
                                }
                                break;
                            case 5:
                                switch (reto)
                                {
                                    case 1:
                                        nivel = item.Value.getE5R1(); break;
                                    case 2:
                                        nivel = item.Value.getE5R2(); break;
                                }
                                break;
                            case 6:
                                switch (reto)
                                {
                                    case 1:
                                        nivel = item.Value.getE6R1(); break;
                                    case 2:
                                        nivel = item.Value.getE6R2(); break;
                                    case 3:
                                        nivel = item.Value.getE6R3(); break;
                                    case 4:
                                        nivel = item.Value.getE6R4(); break;
                                    case 5:
                                        nivel = item.Value.getE6R5(); break;
                                    case 6:
                                        nivel = item.Value.getE6R6(); break;
                                    case 7:
                                        nivel = item.Value.getE6R7(); break;
                                    case 8:
                                        nivel = item.Value.getE6R8(); break;
                                    case 9:
                                        nivel = item.Value.getE6R9(); break;
                                    case 10:
                                        nivel = item.Value.getE6R10(); break;
                                    case 11:
                                        nivel = item.Value.getE6R11(); break;
                                    case 12:
                                        nivel = item.Value.getE6R12(); break;
                                    case 13:
                                        nivel = item.Value.getE6R13(); break;
                                    case 14:
                                        nivel = item.Value.getE6R14(); break;
                                }
                                break;
                            case 7:
                                switch (reto)
                                {
                                    case 1:
                                        nivel = item.Value.getE7R1(); break;
                                    case 2:
                                        nivel = item.Value.getE7R2(); break;
                                    case 3:
                                        nivel = item.Value.getE7R3(); break;
                                    case 4:
                                        nivel = item.Value.getE7R4(); break;
                                    case 5:
                                        nivel = item.Value.getE7R5(); break;
                                    case 6:
                                        nivel = item.Value.getE7R6(); break;
                                    case 7:
                                        nivel = item.Value.getE7R7(); break;
                                    case 8:
                                        nivel = item.Value.getE7R8(); break;
                                    case 9:
                                        nivel = item.Value.getE7R9(); break;
                                    case 10:
                                        nivel = item.Value.getE7R10(); break;
                                    case 11:
                                        nivel = item.Value.getE7R11(); break;
                                    case 12:
                                        nivel = item.Value.getE7R12(); break;
                                    case 13:
                                        nivel = item.Value.getE7R13(); break;
                                    case 14:
                                        nivel = item.Value.getE7R14(); break;
                                    case 15:
                                        nivel = item.Value.getE7R15(); break;
                                    case 16:
                                        nivel = item.Value.getE7R16(); break;
                                }
                                break;
                            case 8:
                                switch (reto)
                                {
                                    case 1:
                                        nivel = item.Value.getE8R1(); break;
                                    case 2:
                                        nivel = item.Value.getE8R2(); break;
                                    case 3:
                                        nivel = item.Value.getE8R3(); break;
                                    case 4:
                                        nivel = item.Value.getE8R4(); break;
                                    case 5:
                                        nivel = item.Value.getE8R5(); break;
                                    case 6:
                                        nivel = item.Value.getE8R6(); break;
                                    case 7:
                                        nivel = item.Value.getE8R7(); break;
                                    case 8:
                                        nivel = item.Value.getE8R8(); break;
                                    case 9:
                                        nivel = item.Value.getE8R9(); break;
                                    case 10:
                                        nivel = item.Value.getE8R10(); break;
                                    case 11:
                                        nivel = item.Value.getE8R11(); break;
                                    case 12:
                                        nivel = item.Value.getE8R12(); break;
                                    case 13:
                                        nivel = item.Value.getE8R13(); break;
                                    case 14:
                                        nivel = item.Value.getE8R14(); break;
                                }
                                break;
                            case 9:
                                switch (reto)
                                {
                                    case 1:
                                        nivel = item.Value.getE9R1(); break;
                                    case 2:
                                        nivel = item.Value.getE9R2(); break;
                                    case 3:
                                        nivel = item.Value.getE9R3(); break;
                                }
                                break;
                            case 10:
                                switch (reto)
                                {
                                    case 1:
                                        nivel = item.Value.getE10R1(); break;
                                    case 2:
                                        nivel = item.Value.getE10R2(); break;
                                    case 3:
                                        nivel = item.Value.getE10R3(); break;
                                    case 4:
                                        nivel = item.Value.getE10R4(); break;
                                    case 5:
                                        nivel = item.Value.getE10R5(); break;
                                    case 6:
                                        nivel = item.Value.getE10R6(); break;
                                    case 7:
                                        nivel = item.Value.getE10R7(); break;
                                    case 8:
                                        nivel = item.Value.getE10R8(); break;
                                    case 9:
                                        nivel = item.Value.getE10R9(); break;
                                    case 10:
                                        nivel = item.Value.getE10R10(); break;
                                    case 11:
                                        nivel = item.Value.getE10R11(); break;
                                }
                                break;
                            case 11:
                                switch (reto)
                                {
                                    case 1:
                                        nivel = item.Value.getE11R1(); break;
                                    case 2:
                                        nivel = item.Value.getE11R2(); break;
                                    case 3:
                                        nivel = item.Value.getE11R3(); break;
                                    case 4:
                                        nivel = item.Value.getE11R4(); break;
                                    case 5:
                                        nivel = item.Value.getE11R5(); break;
                                    case 6:
                                        nivel = item.Value.getE11R6(); break;
                                    case 7:
                                        nivel = item.Value.getE11R7(); break;
                                    case 8:
                                        nivel = item.Value.getE11R8(); break;
                                    case 9:
                                        nivel = item.Value.getE11R9(); break;
                                    case 10:
                                        nivel = item.Value.getE11R10(); break;
                                    case 11:
                                        nivel = item.Value.getE11R11(); break;
                                    case 12:
                                        nivel = item.Value.getE11R12(); break;
                                }
                                break;
                            case 12:
                                switch (reto)
                                {
                                    case 1:
                                        nivel = item.Value.getE12R1(); break;
                                    case 2:
                                        nivel = item.Value.getE12R2(); break;
                                }
                                break;
                            case 13:
                                switch (reto)
                                {
                                    case 1:
                                        nivel = item.Value.getE13R1(); break;
                                    case 2:
                                        nivel = item.Value.getE13R2(); break;
                                    case 3:
                                        nivel = item.Value.getE13R3(); break;
                                    case 4:
                                        nivel = item.Value.getE13R4(); break;
                                    case 5:
                                        nivel = item.Value.getE13R5(); break;
                                    case 6:
                                        nivel = item.Value.getE13R6(); break;
                                    case 7:
                                        nivel = item.Value.getE13R7(); break;
                                    case 8:
                                        nivel = item.Value.getE13R8(); break;
                                    case 9:
                                        nivel = item.Value.getE13R9(); break;
                                    case 10:
                                        nivel = item.Value.getE13R10(); break;
                                    case 11:
                                        nivel = item.Value.getE13R11(); break;
                                    case 12:
                                        nivel = item.Value.getE13R12(); break;
                                    case 13:
                                        nivel = item.Value.getE13R13(); break;
                                    case 14:
                                        nivel = item.Value.getE13R14(); break;
                                    case 15:
                                        nivel = item.Value.getE13R15(); break;
                                }
                                break;
                            case 14:
                                switch (reto)
                                {
                                    case 1:
                                        nivel = item.Value.getE14R1(); break;
                                    case 2:
                                        nivel = item.Value.getE14R2(); break;
                                }
                                break;
                            case 15:
                                switch (reto)
                                {
                                    case 1:
                                        nivel = item.Value.getE15R1(); break;
                                    case 2:
                                        nivel = item.Value.getE15R2(); break;
                                }
                                break;
                            case 16:
                                switch (reto)
                                {
                                    case 1:
                                        nivel = item.Value.getE16R1(); break;
                                    case 2:
                                        nivel = item.Value.getE16R2(); break;
                                    case 3:
                                        nivel = item.Value.getE16R3(); break;
                                    case 4:
                                        nivel = item.Value.getE16R4(); break;
                                    case 5:
                                        nivel = item.Value.getE16R5(); break;
                                    case 6:
                                        nivel = item.Value.getE16R6(); break;
                                    case 7:
                                        nivel = item.Value.getE16R7(); break;
                                    case 8:
                                        nivel = item.Value.getE16R8(); break;
                                    case 9:
                                        nivel = item.Value.getE16R9(); break;
                                    case 10:
                                        nivel = item.Value.getE16R10(); break;
                                }
                                break;
                            case 17:
                                switch (reto)
                                {
                                    case 1:
                                        nivel = item.Value.getE17R1(); break;
                                    case 2:
                                        nivel = item.Value.getE17R2(); break;
                                    case 3:
                                        nivel = item.Value.getE17R3(); break;
                                    case 4:
                                        nivel = item.Value.getE17R4(); break;
                                    case 5:
                                        nivel = item.Value.getE17R5(); break;
                                    case 6:
                                        nivel = item.Value.getE17R6(); break;
                                    case 7:
                                        nivel = item.Value.getE17R7(); break;
                                    case 8:
                                        nivel = item.Value.getE17R8(); break;
                                    case 9:
                                        nivel = item.Value.getE17R9(); break;
                                    case 10:
                                        nivel = item.Value.getE17R10(); break;
                                    case 11:
                                        nivel = item.Value.getE17R11(); break;
                                }
                                break;
                            case 18:
                                switch (reto)
                                {
                                    case 1:
                                        nivel = item.Value.getE18R1(); break;
                                    case 2:
                                        nivel = item.Value.getE18R2(); break;
                                }
                                break;
                            case 19:
                                switch (reto)
                                {
                                    case 1:
                                        nivel = item.Value.getE19R1(); break;
                                    case 2:
                                        nivel = item.Value.getE19R2(); break;
                                    case 3:
                                        nivel = item.Value.getE19R3(); break;
                                    case 4:
                                        nivel = item.Value.getE19R4(); break;
                                    case 5:
                                        nivel = item.Value.getE19R5(); break;
                                    case 6:
                                        nivel = item.Value.getE19R6(); break;
                                    case 7:
                                        nivel = item.Value.getE19R7(); break;
                                    case 8:
                                        nivel = item.Value.getE19R8(); break;
                                    case 9:
                                        nivel = item.Value.getE19R9(); break;
                                    case 10:
                                        nivel = item.Value.getE19R10(); break;
                                    case 11:
                                        nivel = item.Value.getE19R11(); break;
                                    case 12:
                                        nivel = item.Value.getE19R12(); break;
                                    case 13:
                                        nivel = item.Value.getE19R13(); break;
                                }
                                break;

                        }
                        switch (nivel)
                        {
                            case LevelAdvance.NotTried: linea = linea + "," + "level_link not tried"; break;
                            case LevelAdvance.Attempted: linea = linea + "," + "level_link attempted"; break;
                            case LevelAdvance.AttemptedPair: linea = linea + "," + "level_link attempted paired"; break;
                            case LevelAdvance.Passed: linea = linea + "," + "level_link passed"; break;
                            case LevelAdvance.PassedPair: linea = linea + "," + "level_link passed paired"; break;
                            case LevelAdvance.Completed: linea = linea + "," + "level_link perfect"; break;
                            case LevelAdvance.CompletedPair: linea = linea + "," + "level_link perfect paired"; break;
                            case LevelAdvance.NotAssigned: linea = linea + "," + "NOASIGNADO"; break;
                        }                       
                        estudiante++;
                    }
                    sw.WriteLine(linea);
                    numLineasEscritas++;
                    reto++;
                    estudiante = 0;
                }
                etapa++;
                reto = 1;
                estudiante = 0;
            }           
        }

        private void EscribePie(Dictionary<string, Persona> grupo)
        {
            string linea1 = "",linea2 = "",linea3 = "",linea4="",linea5="",linea6="",linea7="";

            for (int i = 1; i <= cantidadEstudiantes; i++)
            {
                string letra = letras[i];
                linea1 = linea1 + "," + "=CONTAR.SI("+letra+"$6:"+letra+"$163;\"level_link not tried\")";
                linea2 = linea2 + "," + "=CONTAR.SI(" + letra + "$6:" + letra + "$163;\"level_link perfect\")";
                linea3 = linea3 + "," + "=CONTAR.SI(" + letra + "$6:" + letra + "$163;\"level_link perfect paired\")";
                linea4 = linea4 + "," + "=CONTAR.SI(" + letra + "$6:" + letra + "$163;\"level_link passed\")";
                linea5 = linea5 + "," + "=CONTAR.SI(" + letra + "$6:" + letra + "$163;\"level_link passed paired\")";
                linea6 = linea6 + "," + "=CONTAR.SI(" + letra + "$6:" + letra + "$163;\"level_link attempted\")";
                linea7 = linea7 + "," + "=CONTAR.SI(" + letra + "$6:" + letra + "$163;\"level_link attempted paired\")";
            }
            linea1 = "level_link not tried, " + linea1;
            sw.WriteLine(linea1);
            linea2 = "level_link perfect, " + linea2;
            sw.WriteLine(linea2);
            linea3 = "level_link perfect paired, " + linea2;
            sw.WriteLine(linea3);
            linea4 = "level_link passed, " + linea3;
            sw.WriteLine(linea4);
            linea5 = "level_link passed paired, " + linea3;
            sw.WriteLine(linea5);
            linea6 = "level_link attempted, " + linea4;
            sw.WriteLine(linea6);
            linea7 = "level_link attempted paired, " + linea4;
            sw.WriteLine(linea7);

        }

    }
}

  
