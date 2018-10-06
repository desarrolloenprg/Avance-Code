using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avance
{
    public class Analizador
    {
        private string htmLine, etapa, reto, bordercolor, lettercolor, backgroundcolor;
        private bool pareado = false;
        public Dictionary<string, Persona> grupo = new Dictionary<string, Persona>();

        public Analizador(string lineAnalizar)
        {
            htmLine = lineAnalizar;
        }

        public Dictionary<string, Persona> BuscaNombres(string ultimoNombre)
        {
            bool acorta = AcortaFile();
            string inicio = "script/18";
            string fin = "</a></div></div>";
            while (true)
            {
                string data = BuscaAlumno(inicio, fin);
                if (data == null)
                    break;

                Persona p1 = new Persona(data);
                grupo.Add(p1.getName(), p1);

                if (!grupo.ContainsKey(data))
                    Console.WriteLine(data + " no existe!");
                else
                    Console.WriteLine(data + " existe!");
            }
            return grupo;
        }

        private bool AcortaFile()
        {
            string inicio = "window.cookieEnvSuffix";
            int pos1 = htmLine.IndexOf(inicio);
            //Get the string position of the next word, starting index being after the first position
            if (pos1 != -1)
            {
                //use substring to obtain the information in between and store in a new string
                htmLine = htmLine.Substring(pos1);
                return true;
            }
            else
                return false;

        }
        private string BuscaAlumno(string strStart, string strEnd)
        {
            //Get the string position of the first word and add length of strStart
            int pos1 = htmLine.IndexOf(strStart);

            if (pos1 >= 0)
            {
                pos1 = pos1 + strStart.Length + 35;
                //Get the string position of the next word, starting index being after the first position
                int pos2 = htmLine.IndexOf(strEnd, pos1);
                //use substring to obtain the information in between and store in a new string
                string data = htmLine.Substring(pos1, pos2 - pos1).Trim();
                htmLine = htmLine.Substring(pos2);
                return data;
            }
            else
                return null;
        }

        public Dictionary<string, Persona> ConstruyeAvance(Dictionary<string, Persona> alumnos)
        {

            int estudiante = 0;
            int stage = 0, mediostage, puzzle = 0, mediopuzzle = -1;
            LevelAdvance level;
            bool firsttime = true;

            int hola = 0;
            while (true)
            {
                if (estudiante == 13)
                    hola = 0;
                if (estudiante < grupo.Count())
                {
                    if (BuscaPuzzle() == null)
                        break;
                }
                else
                    break;

                if (firsttime)
                {
                    Int32.TryParse(etapa, out stage);
                    Int32.TryParse(reto, out puzzle);
                    firsttime = false;
                }
                else
                {
                    Int32.TryParse(etapa, out mediostage);
                    Int32.TryParse(reto, out mediopuzzle);
                    if (stage == mediostage && puzzle == mediopuzzle)
                        estudiante++;
                }
                //Determina level
                level = DeterminaNivel();
                AsignaNivel(level, estudiante);
            }
            return grupo;
        }

        private void AsignaNivel(LevelAdvance nivel, int estudiante)
        {
            var item = grupo.ElementAt(estudiante);
            switch (etapa)
            {
                case "1":
                    switch (reto)
                    {
                        case "1":
                            item.Value.setE1R1(nivel);
                            break;
                        case "2":
                            item.Value.setE1R2(nivel);
                            break;
                        case "3":
                            item.Value.setE1R3(nivel);
                            break;
                    }
                    break;
                case "2":
                    switch (reto)
                    {
                        case "1":
                            item.Value.setE2R1(nivel);
                            break;
                        case "2":
                            item.Value.setE2R2(nivel);
                            break;
                        case "3":
                            item.Value.setE2R3(nivel);
                            break;
                    }
                    break;
                case "3":
                    switch (reto)
                    {
                        case "1":
                            item.Value.setE3R1(nivel);
                            break;
                        case "2":
                            item.Value.setE3R2(nivel);
                            break;
                        case "3":
                            item.Value.setE3R3(nivel);
                            break;
                        case "4":
                            item.Value.setE3R4(nivel);
                            break;
                        case "5":
                            item.Value.setE3R5(nivel);
                            break;
                        case "6":
                            item.Value.setE3R6(nivel);
                            break;
                        case "7":
                            item.Value.setE3R7(nivel);
                            break;
                        case "8":
                            item.Value.setE3R8(nivel);
                            break;
                        case "9":
                            item.Value.setE3R9(nivel);
                            break;
                        case "10":
                            item.Value.setE3R10(nivel);
                            break;
                        case "11":
                            item.Value.setE3R11(nivel);
                            break;
                    }
                    break;
                case "4":
                    switch (reto)
                    {
                        case "1":
                            item.Value.setE4R1(nivel);
                            break;
                        case "2":
                            item.Value.setE4R2(nivel);
                            break;
                        case "3":
                            item.Value.setE4R3(nivel);
                            break;
                        case "4":
                            item.Value.setE4R4(nivel);
                            break;
                        case "5":
                            item.Value.setE4R5(nivel);
                            break;
                        case "6":
                            item.Value.setE4R6(nivel);
                            break;
                        case "7":
                            item.Value.setE4R7(nivel);
                            break;
                        case "8":
                            item.Value.setE4R8(nivel);
                            break;
                        case "9":
                            item.Value.setE4R9(nivel);
                            break;
                        case "10":
                            item.Value.setE4R10(nivel);
                            break;
                        case "11":
                            item.Value.setE4R11(nivel);
                            break;
                        case "12":
                            item.Value.setE4R12(nivel);
                            break;
                    }
                    break;
                case "5":
                    switch (reto)
                    {
                        case "1":
                            item.Value.setE5R1(nivel);
                            break;
                        case "2":
                            item.Value.setE5R2(nivel);
                            break;
                    }
                    break;
                case "6":
                    switch (reto)
                    {
                        case "1":
                            item.Value.setE6R1(nivel);
                            break;
                        case "2":
                            item.Value.setE6R2(nivel);
                            break;
                        case "3":
                            item.Value.setE6R3(nivel);
                            break;
                        case "4":
                            item.Value.setE6R4(nivel);
                            break;
                        case "5":
                            item.Value.setE6R5(nivel);
                            break;
                        case "6":
                            item.Value.setE6R6(nivel);
                            break;
                        case "7":
                            item.Value.setE6R7(nivel);
                            break;
                        case "8":
                            item.Value.setE6R8(nivel);
                            break;
                        case "9":
                            item.Value.setE6R9(nivel);
                            break;
                        case "10":
                            item.Value.setE6R10(nivel);
                            break;
                        case "11":
                            item.Value.setE6R11(nivel);
                            break;
                        case "12":
                            item.Value.setE6R12(nivel);
                            break;
                        case "13":
                            item.Value.setE6R13(nivel);
                            break;
                        case "14":
                            item.Value.setE6R14(nivel);
                            break;
                    }
                    break;
                case "7":
                    switch (reto)
                    {
                        case "1":
                            item.Value.setE7R1(nivel);
                            break;
                        case "2":
                            item.Value.setE7R2(nivel);
                            break;
                        case "3":
                            item.Value.setE7R3(nivel);
                            break;
                        case "4":
                            item.Value.setE7R4(nivel);
                            break;
                        case "5":
                            item.Value.setE7R5(nivel);
                            break;
                        case "6":
                            item.Value.setE7R6(nivel);
                            break;
                        case "7":
                            item.Value.setE7R7(nivel);
                            break;
                        case "8":
                            item.Value.setE7R8(nivel);
                            break;
                        case "9":
                            item.Value.setE7R9(nivel);
                            break;
                        case "10":
                            item.Value.setE7R10(nivel);
                            break;
                        case "11":
                            item.Value.setE7R11(nivel);
                            break;
                        case "12":
                            item.Value.setE7R12(nivel);
                            break;
                        case "13":
                            item.Value.setE7R13(nivel);
                            break;
                        case "14":
                            item.Value.setE7R14(nivel);
                            break;
                        case "15":
                            item.Value.setE7R15(nivel);
                            break;
                        case "16":
                            item.Value.setE7R16(nivel);
                            break;
                    }
                    break;
                case "8":
                    switch (reto)
                    {
                        case "1":
                            item.Value.setE8R1(nivel);
                            break;
                        case "2":
                            item.Value.setE8R2(nivel);
                            break;
                        case "3":
                            item.Value.setE8R3(nivel);
                            break;
                        case "4":
                            item.Value.setE8R4(nivel);
                            break;
                        case "5":
                            item.Value.setE8R5(nivel);
                            break;
                        case "6":
                            item.Value.setE8R6(nivel);
                            break;
                        case "7":
                            item.Value.setE8R7(nivel);
                            break;
                        case "8":
                            item.Value.setE8R8(nivel);
                            break;
                        case "9":
                            item.Value.setE8R9(nivel);
                            break;
                        case "10":
                            item.Value.setE8R10(nivel);
                            break;
                        case "11":
                            item.Value.setE8R11(nivel);
                            break;
                        case "12":
                            item.Value.setE8R12(nivel);
                            break;
                        case "13":
                            item.Value.setE8R13(nivel);
                            break;
                        case "14":
                            item.Value.setE8R14(nivel);
                            break;
                    }
                    break;
                case "9":
                    switch (reto)
                    {
                        case "1":
                            item.Value.setE9R1(nivel);
                            break;
                        case "2":
                            item.Value.setE9R2(nivel);
                            break;
                        case "3":
                            item.Value.setE9R3(nivel);
                            break;
                    }
                    break;
                case "10":
                    switch (reto)
                    {
                        case "1":
                            item.Value.setE10R1(nivel);
                            break;
                        case "2":
                            item.Value.setE10R2(nivel);
                            break;
                        case "3":
                            item.Value.setE10R3(nivel);
                            break;
                        case "4":
                            item.Value.setE10R4(nivel);
                            break;
                        case "5":
                            item.Value.setE10R5(nivel);
                            break;
                        case "6":
                            item.Value.setE10R6(nivel);
                            break;
                        case "7":
                            item.Value.setE10R7(nivel);
                            break;
                        case "8":
                            item.Value.setE10R8(nivel);
                            break;
                        case "9":
                            item.Value.setE10R9(nivel);
                            break;
                        case "10":
                            item.Value.setE10R10(nivel);
                            break;
                        case "11":
                            item.Value.setE10R11(nivel);
                            break;
                    }
                    break;
                case "11":
                    switch (reto)
                    {
                        case "1":
                            item.Value.setE11R1(nivel);
                            break;
                        case "2":
                            item.Value.setE11R2(nivel);
                            break;
                        case "3":
                            item.Value.setE11R3(nivel);
                            break;
                        case "4":
                            item.Value.setE11R4(nivel);
                            break;
                        case "5":
                            item.Value.setE11R5(nivel);
                            break;
                        case "6":
                            item.Value.setE11R6(nivel);
                            break;
                        case "7":
                            item.Value.setE11R7(nivel);
                            break;
                        case "8":
                            item.Value.setE11R8(nivel);
                            break;
                        case "9":
                            item.Value.setE11R9(nivel);
                            break;
                        case "10":
                            item.Value.setE11R10(nivel);
                            break;
                        case "11":
                            item.Value.setE11R11(nivel);
                            break;
                        case "12":
                            item.Value.setE11R12(nivel);
                            break;
                    }
                    break;
                case "12":
                    switch (reto)
                    {
                        case "1":
                            item.Value.setE12R1(nivel);
                            break;
                        case "2":
                            item.Value.setE12R2(nivel);
                            break;
                    }
                    break;
                case "13":
                    switch (reto)
                    {
                        case "1":
                            item.Value.setE13R1(nivel);
                            break;
                        case "2":
                            item.Value.setE13R2(nivel);
                            break;
                        case "3":
                            item.Value.setE13R3(nivel);
                            break;
                        case "4":
                            item.Value.setE13R4(nivel);
                            break;
                        case "5":
                            item.Value.setE13R5(nivel);
                            break;
                        case "6":
                            item.Value.setE13R6(nivel);
                            break;
                        case "7":
                            item.Value.setE13R7(nivel);
                            break;
                        case "8":
                            item.Value.setE13R8(nivel);
                            break;
                        case "9":
                            item.Value.setE13R9(nivel);
                            break;
                        case "10":
                            item.Value.setE13R10(nivel);
                            break;
                        case "11":
                            item.Value.setE13R11(nivel);
                            break;
                        case "12":
                            item.Value.setE13R12(nivel);
                            break;
                        case "13":
                            item.Value.setE13R13(nivel);
                            break;
                        case "14":
                            item.Value.setE13R14(nivel);
                            break;
                        case "15":
                            item.Value.setE13R15(nivel);
                            break;
                    }
                    break;
                case "14":
                    switch (reto)
                    {
                        case "1":
                            item.Value.setE14R1(nivel);
                            break;
                        case "2":
                            item.Value.setE14R2(nivel);
                            break;
                    }
                    break;
                case "15":
                    switch (reto)
                    {
                        case "1":
                            item.Value.setE15R1(nivel);
                            break;
                        case "2":
                            item.Value.setE15R2(nivel);
                            break;
                    }
                    break;
                case "16":
                    switch (reto)
                    {
                        case "1":
                            item.Value.setE16R1(nivel);
                            break;
                        case "2":
                            item.Value.setE16R2(nivel);
                            break;
                        case "3":
                            item.Value.setE16R3(nivel);
                            break;
                        case "4":
                            item.Value.setE16R4(nivel);
                            break;
                        case "5":
                            item.Value.setE16R5(nivel);
                            break;
                        case "6":
                            item.Value.setE16R6(nivel);
                            break;
                        case "7":
                            item.Value.setE16R7(nivel);
                            break;
                        case "8":
                            item.Value.setE16R8(nivel);
                            break;
                        case "9":
                            item.Value.setE16R9(nivel);
                            break;
                        case "10":
                            item.Value.setE16R10(nivel);
                            break;
                    }
                    break;
                case "17":
                    switch (reto)
                    {
                        case "1":
                            item.Value.setE17R1(nivel);
                            break;
                        case "2":
                            item.Value.setE17R2(nivel);
                            break;
                        case "3":
                            item.Value.setE17R3(nivel);
                            break;
                        case "4":
                            item.Value.setE17R4(nivel);
                            break;
                        case "5":
                            item.Value.setE17R5(nivel);
                            break;
                        case "6":
                            item.Value.setE17R6(nivel);
                            break;
                        case "7":
                            item.Value.setE17R7(nivel);
                            break;
                        case "8":
                            item.Value.setE17R8(nivel);
                            break;
                        case "9":
                            item.Value.setE17R9(nivel);
                            break;
                        case "10":
                            item.Value.setE17R10(nivel);
                            break;
                        case "11":
                            item.Value.setE17R11(nivel);
                            break;
                    }
                    break;
                case "18":
                    switch (reto)
                    {
                        case "1":
                            item.Value.setE18R1(nivel);
                            break;
                        case "2":
                            item.Value.setE18R2(nivel);
                            break;
                    }
                    break;
                case "19":
                    switch (reto)
                    {
                        case "1":
                            item.Value.setE19R1(nivel);
                            break;
                        case "2":
                            item.Value.setE19R2(nivel);
                            break;
                        case "3":
                            item.Value.setE19R3(nivel);
                            break;
                        case "4":
                            item.Value.setE19R4(nivel);
                            break;
                        case "5":
                            item.Value.setE19R5(nivel);
                            break;
                        case "6":
                            item.Value.setE19R6(nivel);
                            break;
                        case "7":
                            item.Value.setE19R7(nivel);
                            break;
                        case "8":
                            item.Value.setE19R8(nivel);
                            break;
                        case "9":
                            item.Value.setE19R9(nivel);
                            break;
                        case "10":
                            item.Value.setE19R10(nivel);
                            break;
                        case "11":
                            item.Value.setE19R11(nivel);
                            break;
                        case "12":
                            item.Value.setE19R12(nivel);
                            break;
                        case "13":
                            item.Value.setE19R13(nivel);
                            break;
                    }
                    break;

            }

        }

        private LevelAdvance DeterminaNivel()
        {
            if (bordercolor == "0, 0, 0" || bordercolor == "14, 190, 14")
            {
                if (lettercolor == "255, 255, 255" && backgroundcolor == "14, 190, 14")
                    if (pareado)
                        return LevelAdvance.CompletedPair;
                    else
                        return LevelAdvance.Completed;
                if (lettercolor == "91, 103, 112" && backgroundcolor == "159, 212, 159")
                    if (pareado)
                        return LevelAdvance.PassedPair;
                    else
                        return LevelAdvance.Passed;
                if (lettercolor == "91, 103, 112" && backgroundcolor == "254, 254, 254")
                    if (pareado)
                        return LevelAdvance.AttemptedPair;
                    else
                        return LevelAdvance.Attempted;
            }
            if (bordercolor == "198, 202, 205")
            {
                if (lettercolor == "91, 103, 112" && backgroundcolor == "254, 254, 254")

                    return LevelAdvance.NotTried;
            }

            return LevelAdvance.NotTried;
        }

        private string BuscaPuzzle()
        {
            etapa = reto = null;
            string strStart = "http://studio.code.org/s/course2/stage/";  
            string strEnd = "data-radium";
            //Get the string position of the first word and add length of strStart
            int pos1 = htmLine.IndexOf(strStart);
            //Get the string position of the next word, starting index being after the first position
            if (pos1 == -1)
                return null;
            int pos2 = htmLine.IndexOf(strEnd, pos1);
            int pos3, pos4;
            if (pos2 != -1)
            {
                //use substring to obtain the information in between and store in a new string
                string data = htmLine.Substring(pos1, pos2 - pos1).Trim();
                htmLine = htmLine.Substring(pos2);

                //etapa
                pos3 = data.IndexOf("stage/") + 6;
                pos4 = data.IndexOf("/puzzle");
                etapa = data.Substring(pos3, pos4 - pos3).Trim();
                //reto
                pos3 = data.IndexOf("puzzle/") + 7;
                pos4 = data.IndexOf("\" class");
                reto = data.Substring(pos3, pos4 - pos3).Trim();
                //htmLine = htmLine.Substring(pos2);
                if ((pos4 = data.IndexOf("?section")) != -1)
                {
                    reto = data.Substring(pos3, pos4 - pos3).Trim();
                }
                //border-color
                pos1 = htmLine.IndexOf("border-color: rgb(") + 18;
                pos2 = htmLine.IndexOf(")",pos1);
                bordercolor = htmLine.Substring(pos1, pos2 - pos1).Trim();
                /*if ((pos4 = bordercolor.IndexOf("); font-size")) != -1)
                {
                    pos3 = 0;
                    bordercolor = bordercolor.Substring(pos3, pos4 - pos3).Trim();
                }*/
                //color - color de las letras
                pos1 = htmLine.IndexOf(" color: rgb(") + 12;
                //pos2 = htmLine.IndexOf("); display: flex;");
                //pos2 = htmLine.IndexOf("); background-color: rgb(");
                pos2 = htmLine.IndexOf(")", pos1);
                /*if (pos2 == -1)
                {
                    pos2 = htmLine.IndexOf(" background-color: rgb(");
                }*/
                lettercolor = htmLine.Substring(pos1, pos2 - pos1).Trim();
                //background-color - color de las letras
                //htmLine = htmLine.Substring(pos2);
                pos1 = htmLine.IndexOf("background-color: rgb(") + 22;
                //pos2 = htmLine.IndexOf(");\"><div data-radium=");
                pos2 = htmLine.IndexOf(")", pos1);
                backgroundcolor = htmLine.Substring(pos1, pos2 - pos1).Trim();
                //pareado
                //htmLine = htmLine.Substring(pos2);
                pos1 = htmLine.IndexOf(");\"><div data-radium=") + 22;
                pos2 = htmLine.IndexOf("</a>",pos1);
                string temporal = htmLine.Substring(pos1, pos2 - pos1).Trim();
                if (temporal.IndexOf("fa fa-users") != -1)
                    pareado = true;
                else
                    pareado = false;

                //htmLine = htmLine.Substring(pos2);
                return data;
            }
            else
                return null;
        }
    }
}
