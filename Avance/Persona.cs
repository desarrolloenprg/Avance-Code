using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avance
{
    public class Persona
    {
        private string Name { get; set; }
        private LevelAdvance E1R1 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E1R2 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E1R3 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E2R1 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E2R2 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E2R3 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E3R1 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E3R2 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E3R3 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E3R4 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E3R5 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E3R6 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E3R7 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E3R8 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E3R9 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E3R10 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E3R11 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E4R1 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E4R2 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E4R3 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E4R4 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E4R5 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E4R6 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E4R7 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E4R8 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E4R9 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E4R10 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E4R11 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E4R12 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E5R1 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E5R2 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E6R1 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E6R2 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E6R3 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E6R4 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E6R5 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E6R6 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E6R7 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E6R8 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E6R9 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E6R10 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E6R11 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E6R12 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E6R13 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E6R14 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E7R1 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E7R2 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E7R3 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E7R4 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E7R5 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E7R6 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E7R7 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E7R8 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E7R9 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E7R10 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E7R11 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E7R12 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E7R13 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E7R14 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E7R15 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E7R16 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E8R1 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E8R2 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E8R3 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E8R4 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E8R5 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E8R6 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E8R7 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E8R8 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E8R9 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E8R10 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E8R11 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E8R12 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E8R13 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E8R14 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E9R1 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E9R2 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E9R3 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E10R1 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E10R2 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E10R3 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E10R4 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E10R5 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E10R6 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E10R7 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E10R8 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E10R9 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E10R10 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E10R11 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E11R1 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E11R2 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E11R3 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E11R4 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E11R5 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E11R6 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E11R7 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E11R8 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E11R9 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E11R10 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E11R11 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E11R12 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E12R1 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E12R2 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E13R1 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E13R2 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E13R3 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E13R4 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E13R5 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E13R6 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E13R7 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E13R8 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E13R9 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E13R10 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E13R11 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E13R12 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E13R13 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E13R14 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E13R15 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E14R1 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E14R2 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E15R1 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E15R2 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E16R1 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E16R2 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E16R3 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E16R4 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E16R5 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E16R6 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E16R7 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E16R8 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E16R9 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E16R10 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E17R1 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E17R2 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E17R3 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E17R4 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E17R5 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E17R6 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E17R7 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E17R8 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E17R9 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E17R10 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E17R11 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E18R1 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E18R2 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E19R1 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E19R2 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E19R3 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E19R4 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E19R5 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E19R6 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E19R7 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E19R8 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E19R9 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E19R10 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E19R11 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E19R12 { get; set; } = LevelAdvance.NotAssigned;
        private LevelAdvance E19R13 { get; set; } = LevelAdvance.NotAssigned;

        public Persona(string name)
        {
            Name = name;

        }

        public void setName(string name)
        {
            Name = name;
        }
        public void setE1R1(LevelAdvance e1r1)
        {
            E1R1 = e1r1;
        }
        public void setE1R2(LevelAdvance e1r2)
        {
            E1R2 = e1r2;
        }
        public void setE1R3(LevelAdvance e1r3)
        {
            E1R3 = e1r3;
        }
        public void setE2R1(LevelAdvance e2r1)
        {
            E2R1 = e2r1;
        }
        public void setE2R2(LevelAdvance e2r2)
        {
            E2R2 = e2r2;
        }
        public void setE2R3(LevelAdvance e2r3)
        {
            E2R3 = e2r3;
        }
        public void setE3R1(LevelAdvance e3r1)
        {
            E3R1 = e3r1;
        }
        public void setE3R2(LevelAdvance e3r2)
        {
            E3R2 = e3r2;
        }
        public void setE3R3(LevelAdvance e3r3)
        {
            E3R3 = e3r3;
        }
        public void setE3R4(LevelAdvance e3r4)
        {
            E3R4 = e3r4;
        }
        public void setE3R5(LevelAdvance e3r5)
        {
            E3R5 = e3r5;
        }
        public void setE3R6(LevelAdvance e3r6)
        {
            E3R6 = e3r6;
        }
        public void setE3R7(LevelAdvance e3r7)
        {
            E3R7 = e3r7;
        }
        public void setE3R8(LevelAdvance e3r8)
        {
            E3R8 = e3r8;
        }
        public void setE3R9(LevelAdvance e3r9)
        {
            E3R9 = e3r9;
        }
        public void setE3R10(LevelAdvance e3r10)
        {
            E3R10 = e3r10;
        }
        public void setE3R11(LevelAdvance e3r11)
        {
            E3R11 = e3r11;
        }
        public void setE4R1(LevelAdvance e4r1)
        {
            E4R1 = e4r1;
        }
        public void setE4R2(LevelAdvance niv)
        {
            E4R2 = niv;
        }
        public void setE4R3(LevelAdvance niv)
        {
            E4R3 = niv;
        }
        public void setE4R4(LevelAdvance niv)
        {
            E4R4 = niv;
        }
        public void setE4R5(LevelAdvance niv)
        {
            E4R5 = niv;
        }
        public void setE4R6(LevelAdvance niv)
        {
            E4R6 = niv;
        }
        public void setE4R7(LevelAdvance niv)
        {
            E4R7 = niv;
        }
        public void setE4R8(LevelAdvance niv)
        {
            E4R8 = niv;
        }
        public void setE4R9(LevelAdvance niv)
        {
            E4R9 = niv;
        }
        public void setE4R10(LevelAdvance niv)
        {
            E4R10 = niv;
        }
        public void setE4R11(LevelAdvance niv)
        {
            E4R11 = niv;
        }
        public void setE4R12(LevelAdvance niv)
        {
            E4R12 = niv;
        }
        public void setE5R1(LevelAdvance niv)
        {
            E5R1 = niv;
        }
        public void setE5R2(LevelAdvance niv)
        {
            E5R2 = niv;
        }
        public void setE6R1(LevelAdvance niv)
        {
            E6R1 = niv;
        }
        public void setE6R2(LevelAdvance niv)
        {
            E6R2 = niv;
        }
        public void setE6R3(LevelAdvance niv)
        {
            E6R3 = niv;
        }
        public void setE6R4(LevelAdvance niv)
        {
            E6R4 = niv;
        }
        public void setE6R5(LevelAdvance niv)
        {
            E6R5 = niv;
        }
        public void setE6R6(LevelAdvance niv)
        {
            E6R6 = niv;
        }
        public void setE6R7(LevelAdvance niv)
        {
            E6R7 = niv;
        }
        public void setE6R8(LevelAdvance niv)
        {
            E6R8 = niv;
        }
        public void setE6R9(LevelAdvance niv)
        {
            E6R9 = niv;
        }
        public void setE6R10(LevelAdvance niv)
        {
            E6R10 = niv;
        }
        public void setE6R11(LevelAdvance niv)
        {
            E6R11 = niv;
        }
        public void setE6R12(LevelAdvance niv)
        {
            E6R12 = niv;
        }
        public void setE6R13(LevelAdvance niv)
        {
            E6R13 = niv;
        }
        public void setE6R14(LevelAdvance niv)
        {
            E6R14 = niv;
        }
        public void setE7R1(LevelAdvance niv)
        {
            E7R1 = niv;
        }
        public void setE7R2(LevelAdvance niv)
        {
            E7R2 = niv;
        }
        public void setE7R3(LevelAdvance niv)
        {
            E7R3 = niv;
        }
        public void setE7R4(LevelAdvance niv)
        {
            E7R4 = niv;
        }
        public void setE7R5(LevelAdvance niv)
        {
            E7R5 = niv;
        }
        public void setE7R6(LevelAdvance niv)
        {
            E7R6 = niv;
        }
        public void setE7R7(LevelAdvance niv)
        {
            E7R7 = niv;
        }
        public void setE7R8(LevelAdvance niv)
        {
            E7R8 = niv;
        }
        public void setE7R9(LevelAdvance niv)
        {
            E7R9 = niv;
        }
        public void setE7R10(LevelAdvance niv)
        {
            E7R10 = niv;
        }
        public void setE7R11(LevelAdvance niv)
        {
            E7R11 = niv;
        }
        public void setE7R12(LevelAdvance niv)
        {
            E7R12 = niv;
        }
        public void setE7R13(LevelAdvance niv)
        {
            E7R13 = niv;
        }
        public void setE7R14(LevelAdvance niv)
        {
            E7R14 = niv;
        }
        public void setE7R15(LevelAdvance niv)
        {
            E7R15 = niv;
        }
        public void setE7R16(LevelAdvance niv)
        {
            E7R16 = niv;
        }
        public void setE8R1(LevelAdvance niv)
        {
            E8R1 = niv;
        }
        public void setE8R2(LevelAdvance niv)
        {
            E8R2 = niv;
        }
        public void setE8R3(LevelAdvance niv)
        {
            E8R3 = niv;
        }
        public void setE8R4(LevelAdvance niv)
        {
            E8R4 = niv;
        }
        public void setE8R5(LevelAdvance niv)
        {
            E8R5 = niv;
        }
        public void setE8R6(LevelAdvance niv)
        {
            E8R6 = niv;
        }
        public void setE8R7(LevelAdvance niv)
        {
            E8R7 = niv;
        }
        public void setE8R8(LevelAdvance niv)
        {
            E8R8 = niv;
        }
        public void setE8R9(LevelAdvance niv)
        {
            E8R9 = niv;
        }
        public void setE8R10(LevelAdvance niv)
        {
            E8R10 = niv;
        }
        public void setE8R11(LevelAdvance niv)
        {
            E8R11 = niv;
        }
        public void setE8R12(LevelAdvance niv)
        {
            E8R12 = niv;
        }
        public void setE8R13(LevelAdvance niv)
        {
            E8R13 = niv;
        }
        public void setE8R14(LevelAdvance niv)
        {
            E8R14 = niv;
        }
        public void setE9R1(LevelAdvance niv)
        {
            E9R1 = niv;
        }
        public void setE9R2(LevelAdvance niv)
        {
            E9R2 = niv;
        }
        public void setE9R3(LevelAdvance niv)
        {
            E9R3 = niv;
        }
        public void setE10R1(LevelAdvance niv)
        {
            E10R1 = niv;
        }
        public void setE10R2(LevelAdvance niv)
        {
            E10R2 = niv;
        }
        public void setE10R3(LevelAdvance niv)
        {
            E10R3 = niv;
        }
        public void setE10R4(LevelAdvance niv)
        {
            E10R4 = niv;
        }
        public void setE10R5(LevelAdvance niv)
        {
            E10R5 = niv;
        }
        public void setE10R6(LevelAdvance niv)
        {
            E10R6 = niv;
        }
        public void setE10R7(LevelAdvance niv)
        {
            E10R7 = niv;
        }
        public void setE10R8(LevelAdvance niv)
        {
            E10R8 = niv;
        }
        public void setE10R9(LevelAdvance niv)
        {
            E10R9 = niv;
        }
        public void setE10R10(LevelAdvance niv)
        {
            E10R10 = niv;
        }
        public void setE10R11(LevelAdvance niv)
        {
            E10R11 = niv;
        }
        public void setE11R1(LevelAdvance niv)
        {
            E11R1 = niv;
        }
        public void setE11R2(LevelAdvance niv)
        {
            E11R2 = niv;
        }
        public void setE11R3(LevelAdvance niv)
        {
            E11R3 = niv;
        }
        public void setE11R4(LevelAdvance niv)
        {
            E11R4 = niv;
        }
        public void setE11R5(LevelAdvance niv)
        {
            E11R5 = niv;
        }
        public void setE11R6(LevelAdvance niv)
        {
            E11R6 = niv;
        }
        public void setE11R7(LevelAdvance niv)
        {
            E11R7 = niv;
        }
        public void setE11R8(LevelAdvance niv)
        {
            E11R8 = niv;
        }
        public void setE11R9(LevelAdvance niv)
        {
            E11R9 = niv;
        }
        public void setE11R10(LevelAdvance niv)
        {
            E11R10 = niv;
        }
        public void setE11R11(LevelAdvance niv)
        {
            E11R11 = niv;
        }
        public void setE11R12(LevelAdvance niv)
        {
            E11R12 = niv;
        }
        public void setE12R1(LevelAdvance niv)
        {
            E12R1 = niv;
        }
        public void setE12R2(LevelAdvance niv)
        {
            E12R2 = niv;
        }
        public void setE13R1(LevelAdvance niv)
        {
            E13R1 = niv;
        }
        public void setE13R2(LevelAdvance niv)
        {
            E13R2 = niv;
        }
        public void setE13R3(LevelAdvance niv)
        {
            E13R3 = niv;
        }
        public void setE13R4(LevelAdvance niv)
        {
            E13R4 = niv;
        }
        public void setE13R5(LevelAdvance niv)
        {
            E13R5 = niv;
        }
        public void setE13R6(LevelAdvance niv)
        {
            E13R6 = niv;
        }
        public void setE13R7(LevelAdvance niv)
        {
            E13R7 = niv;
        }
        public void setE13R8(LevelAdvance niv)
        {
            E13R8 = niv;
        }
        public void setE13R9(LevelAdvance niv)
        {
            E13R9 = niv;
        }
        public void setE13R10(LevelAdvance niv)
        {
            E13R10 = niv;
        }
        public void setE13R11(LevelAdvance niv)
        {
            E13R11 = niv;
        }
        public void setE13R12(LevelAdvance niv)
        {
            E13R12 = niv;
        }
        public void setE13R13(LevelAdvance niv)
        {
            E13R13 = niv;
        }
        public void setE13R14(LevelAdvance niv)
        {
            E13R14 = niv;
        }
        public void setE13R15(LevelAdvance niv)
        {
            E13R15 = niv;
        }
        public void setE14R1(LevelAdvance niv)
        {
            E14R1 = niv;
        }
        public void setE14R2(LevelAdvance niv)
        {
            E14R2 = niv;
        }
        public void setE15R1(LevelAdvance niv)
        {
            E15R1 = niv;
        }
        public void setE15R2(LevelAdvance niv)
        {
            E15R2 = niv;
        }
        public void setE16R1(LevelAdvance niv)
        {
            E16R1 = niv;
        }
        public void setE16R2(LevelAdvance niv)
        {
            E16R2 = niv;
        }
        public void setE16R3(LevelAdvance niv)
        {
            E16R3 = niv;
        }
        public void setE16R4(LevelAdvance niv)
        {
            E16R4 = niv;
        }
        public void setE16R5(LevelAdvance niv)
        {
            E16R5 = niv;
        }
        public void setE16R6(LevelAdvance niv)
        {
            E16R6 = niv;
        }
        public void setE16R7(LevelAdvance niv)
        {
            E16R7 = niv;
        }
        public void setE16R8(LevelAdvance niv)
        {
            E16R8 = niv;
        }
        public void setE16R9(LevelAdvance niv)
        {
            E16R9 = niv;
        }
        public void setE16R10(LevelAdvance niv)
        {
            E16R10 = niv;
        }
        public void setE17R1(LevelAdvance niv)
        {
            E17R1 = niv;
        }
        public void setE17R2(LevelAdvance niv)
        {
            E17R2 = niv;
        }
        public void setE17R3(LevelAdvance niv)
        {
            E17R3 = niv;
        }
        public void setE17R4(LevelAdvance niv)
        {
            E17R4 = niv;
        }
        public void setE17R5(LevelAdvance niv)
        {
            E17R5 = niv;
        }
        public void setE17R6(LevelAdvance niv)
        {
            E17R6 = niv;
        }
        public void setE17R7(LevelAdvance niv)
        {
            E17R7 = niv;
        }
        public void setE17R8(LevelAdvance niv)
        {
            E17R8 = niv;
        }
        public void setE17R9(LevelAdvance niv)
        {
            E17R9 = niv;
        }
        public void setE17R10(LevelAdvance niv)
        {
            E17R10 = niv;
        }
        public void setE17R11(LevelAdvance niv)
        {
            E17R11 = niv;
        }
        public void setE18R1(LevelAdvance niv)
        {
            E18R1 = niv;
        }
        public void setE18R2(LevelAdvance niv)
        {
            E18R2 = niv;
        }
        public void setE19R1(LevelAdvance niv)
        {
            E19R1 = niv;
        }
        public void setE19R2(LevelAdvance niv)
        {
            E19R2 = niv;
        }
        public void setE19R3(LevelAdvance niv)
        {
            E19R3 = niv;
        }
        public void setE19R4(LevelAdvance niv)
        {
            E19R4 = niv;
        }
        public void setE19R5(LevelAdvance niv)
        {
            E19R5 = niv;
        }
        public void setE19R6(LevelAdvance niv)
        {
            E19R6 = niv;
        }
        public void setE19R7(LevelAdvance niv)
        {
            E19R7 = niv;
        }
        public void setE19R8(LevelAdvance niv)
        {
            E19R8 = niv;
        }
        public void setE19R9(LevelAdvance niv)
        {
            E19R9 = niv;
        }
        public void setE19R10(LevelAdvance niv)
        {
            E19R10 = niv;
        }
        public void setE19R11(LevelAdvance niv)
        {
            E19R11 = niv;
        }
        public void setE19R12(LevelAdvance niv)
        {
            E19R12 = niv;
        }
        public void setE19R13(LevelAdvance niv)
        {
            E19R13 = niv;
        }


        public string getName()
        {
            return Name;
        }
        public LevelAdvance getE1R1()
        {
            return E1R1;
        }
        public LevelAdvance getE1R2()
        {
            return E1R2;
        }
        public LevelAdvance getE1R3()
        {
            return E1R3;
        }
        public LevelAdvance getE2R1()
        {
            return E2R1;
        }
        public LevelAdvance getE2R2()
        {
            return E2R2;
        }
        public LevelAdvance getE2R3()
        {
            return E2R3;
        }
        public LevelAdvance getE3R1()
        {
            return E3R1;
        }
        public LevelAdvance getE3R2()
        {
            return E3R2;
        }
        public LevelAdvance getE3R3()
        {
            return E3R3;
        }
        public LevelAdvance getE3R4()
        {
            return E3R4;
        }
        public LevelAdvance getE3R5()
        {
            return E3R5;
        }
        public LevelAdvance getE3R6()
        {
            return E3R6;
        }
        public LevelAdvance getE3R7()
        {
            return E3R7;
        }
        public LevelAdvance getE3R8()
        {
            return E3R8;
        }
        public LevelAdvance getE3R9()
        {
            return E3R9;
        }
        public LevelAdvance getE3R10()
        {
            return E3R10;
        }
        public LevelAdvance getE3R11()
        {
            return E3R11;
        }
        public LevelAdvance getE4R1()
        {
            return E4R1;
        }
        public LevelAdvance getE4R2()
        {
            return E4R2;
        }
        public LevelAdvance getE4R3()
        {
            return E4R3;
        }
        public LevelAdvance getE4R4()
        {
            return E4R4;
        }
        public LevelAdvance getE4R5()
        {
            return E4R5;
        }
        public LevelAdvance getE4R6()
        {
            return E4R6;
        }
        public LevelAdvance getE4R7()
        {
            return E4R7;
        }
        public LevelAdvance getE4R8()
        {
            return E4R8;
        }
        public LevelAdvance getE4R9()
        {
            return E4R9;
        }
        public LevelAdvance getE4R10()
        {
            return E4R10;
        }
        public LevelAdvance getE4R11()
        {
            return E4R11;
        }
        public LevelAdvance getE4R12()
        {
            return E4R12;
        }
        public LevelAdvance getE5R1()
        {
            return E5R1;
        }
        public LevelAdvance getE5R2()
        {
            return E5R2;
        }
        public LevelAdvance getE6R1()
        {
            return E6R1;
        }
        public LevelAdvance getE6R2()
        {
            return E6R2;
        }
        public LevelAdvance getE6R3()
        {
            return E6R3;
        }
        public LevelAdvance getE6R4()
        {
            return E6R4;
        }
        public LevelAdvance getE6R5()
        {
            return E6R5;
        }
        public LevelAdvance getE6R6()
        {
            return E6R6;
        }
        public LevelAdvance getE6R7()
        {
            return E6R7;
        }
        public LevelAdvance getE6R8()
        {
            return E6R8;
        }
        public LevelAdvance getE6R9()
        {
            return E6R9;
        }
        public LevelAdvance getE6R10()
        {
            return E6R10;
        }
        public LevelAdvance getE6R11()
        {
            return E6R11;
        }
        public LevelAdvance getE6R12()
        {
            return E6R12;
        }
        public LevelAdvance getE6R13()
        {
            return E6R13;
        }
        public LevelAdvance getE6R14()
        {
            return E6R14;
        }
        public LevelAdvance getE7R1()
        {
            return E7R1;
        }
        public LevelAdvance getE7R2()
        {
            return E7R2;
        }
        public LevelAdvance getE7R3()
        {
            return E7R3;
        }
        public LevelAdvance getE7R4()
        {
            return E7R4;
        }
        public LevelAdvance getE7R5()
        {
            return E7R5;
        }
        public LevelAdvance getE7R6()
        {
            return E7R6;
        }
        public LevelAdvance getE7R7()
        {
            return E7R7;
        }
        public LevelAdvance getE7R8()
        {
            return E7R8;
        }
        public LevelAdvance getE7R9()
        {
            return E7R9;
        }
        public LevelAdvance getE7R10()
        {
            return E7R10;
        }
        public LevelAdvance getE7R11()
        {
            return E7R11;
        }
        public LevelAdvance getE7R12()
        {
            return E7R12;
        }
        public LevelAdvance getE7R13()
        {
            return E7R13;
        }
        public LevelAdvance getE7R14()
        {
            return E7R14;
        }
        public LevelAdvance getE7R15()
        {
            return E7R15;
        }
        public LevelAdvance getE7R16()
        {
            return E7R16;
        }
        public LevelAdvance getE8R1()
        {
            return E8R1;
        }
        public LevelAdvance getE8R2()
        {
            return E8R2;
        }
        public LevelAdvance getE8R3()
        {
            return E8R3;
        }
        public LevelAdvance getE8R4()
        {
            return E8R4;
        }
        public LevelAdvance getE8R5()
        {
            return E8R5;
        }
        public LevelAdvance getE8R6()
        {
            return E8R6;
        }
        public LevelAdvance getE8R7()
        {
            return E8R7;
        }
        public LevelAdvance getE8R8()
        {
            return E8R8;
        }
        public LevelAdvance getE8R9()
        {
            return E8R9;
        }
        public LevelAdvance getE8R10()
        {
            return E8R10;
        }
        public LevelAdvance getE8R11()
        {
            return E8R11;
        }
        public LevelAdvance getE8R12()
        {
            return E8R12;
        }
        public LevelAdvance getE8R13()
        {
            return E8R13;
        }
        public LevelAdvance getE8R14()
        {
            return E8R14;
        }
        public LevelAdvance getE9R1()
        {
            return E9R1;
        }
        public LevelAdvance getE9R2()
        {
            return E9R2;
        }
        public LevelAdvance getE9R3()
        {
            return E9R3;
        }
        public LevelAdvance getE10R1()
        {
            return E10R1;
        }
        public LevelAdvance getE10R2()
        {
            return E10R2;
        }
        public LevelAdvance getE10R3()
        {
            return E10R3;
        }
        public LevelAdvance getE10R4()
        {
            return E10R4;
        }
        public LevelAdvance getE10R5()
        {
            return E10R5;
        }
        public LevelAdvance getE10R6()
        {
            return E10R6;
        }
        public LevelAdvance getE10R7()
        {
            return E10R7;
        }
        public LevelAdvance getE10R8()
        {
            return E10R8;
        }
        public LevelAdvance getE10R9()
        {
            return E10R9;
        }
        public LevelAdvance getE10R10()
        {
            return E10R10;
        }
        public LevelAdvance getE10R11()
        {
            return E10R11;
        }
        public LevelAdvance getE11R1()
        {
            return E11R1;
        }
        public LevelAdvance getE11R2()
        {
            return E11R2;
        }
        public LevelAdvance getE11R3()
        {
            return E11R3;
        }
        public LevelAdvance getE11R4()
        {
            return E11R4;
        }
        public LevelAdvance getE11R5()
        {
            return E11R5;
        }
        public LevelAdvance getE11R6()
        {
            return E11R6;
        }
        public LevelAdvance getE11R7()
        {
            return E11R7;
        }
        public LevelAdvance getE11R8()
        {
            return E11R8;
        }
        public LevelAdvance getE11R9()
        {
            return E11R9;
        }
        public LevelAdvance getE11R10()
        {
            return E11R10;
        }
        public LevelAdvance getE11R11()
        {
            return E11R11;
        }
        public LevelAdvance getE11R12()
        {
            return E11R12;
        }
        public LevelAdvance getE12R1()
        {
            return E12R1;
        }
        public LevelAdvance getE12R2()
        {
            return E12R2;
        }
        public LevelAdvance getE13R1()
        {
            return E13R1;
        }
        public LevelAdvance getE13R2()
        {
            return E13R2;
        }
        public LevelAdvance getE13R3()
        {
            return E13R3;
        }
        public LevelAdvance getE13R4()
        {
            return E13R4;
        }
        public LevelAdvance getE13R5()
        {
            return E13R5;
        }
        public LevelAdvance getE13R6()
        {
            return E13R6;
        }
        public LevelAdvance getE13R7()
        {
            return E13R7;
        }
        public LevelAdvance getE13R8()
        {
            return E13R8;
        }
        public LevelAdvance getE13R9()
        {
            return E13R9;
        }
        public LevelAdvance getE13R10()
        {
            return E13R10;
        }
        public LevelAdvance getE13R11()
        {
            return E13R11;
        }
        public LevelAdvance getE13R12()
        {
            return E13R12;
        }
        public LevelAdvance getE13R13()
        {
            return E13R13;
        }
        public LevelAdvance getE13R14()
        {
            return E13R14;
        }
        public LevelAdvance getE13R15()
        {
            return E13R15;
        }
        public LevelAdvance getE14R1()
        {
            return E14R1;
        }
        public LevelAdvance getE14R2()
        {
            return E14R2;
        }
        public LevelAdvance getE15R1()
        {
            return E15R1;
        }
        public LevelAdvance getE15R2()
        {
            return E15R2;
        }
        public LevelAdvance getE16R1()
        {
            return E16R1;
        }
        public LevelAdvance getE16R2()
        {
            return E16R2;
        }
        public LevelAdvance getE16R3()
        {
            return E16R3;
        }
        public LevelAdvance getE16R4()
        {
            return E16R4;
        }
        public LevelAdvance getE16R5()
        {
            return E16R5;
        }
        public LevelAdvance getE16R6()
        {
            return E16R6;
        }
        public LevelAdvance getE16R7()
        {
            return E16R7;
        }
        public LevelAdvance getE16R8()
        {
            return E16R8;
        }
        public LevelAdvance getE16R9()
        {
            return E16R9;
        }
        public LevelAdvance getE16R10()
        {
            return E16R10;
        }
        public LevelAdvance getE17R1()
        {
            return E17R1;
        }
        public LevelAdvance getE17R2()
        {
            return E17R2;
        }
        public LevelAdvance getE17R3()
        {
            return E17R3;
        }
        public LevelAdvance getE17R4()
        {
            return E17R4;
        }
        public LevelAdvance getE17R5()
        {
            return E17R5;
        }
        public LevelAdvance getE17R6()
        {
            return E17R6;
        }
        public LevelAdvance getE17R7()
        {
            return E17R7;
        }
        public LevelAdvance getE17R8()
        {
            return E17R8;
        }
        public LevelAdvance getE17R9()
        {
            return E17R9;
        }
        public LevelAdvance getE17R10()
        {
            return E17R10;
        }
        public LevelAdvance getE17R11()
        {
            return E17R11;
        }
        public LevelAdvance getE18R1()
        {
            return E18R1;
        }
        public LevelAdvance getE18R2()
        {
            return E18R2;
        }
        public LevelAdvance getE19R1()
        {
            return E19R1;
        }
        public LevelAdvance getE19R2()
        {
            return E19R2;
        }
        public LevelAdvance getE19R3()
        {
            return E19R3;
        }
        public LevelAdvance getE19R4()
        {
            return E19R4;
        }
        public LevelAdvance getE19R5()
        {
            return E19R5;
        }
        public LevelAdvance getE19R6()
        {
            return E19R6;
        }
        public LevelAdvance getE19R7()
        {
            return E19R7;
        }
        public LevelAdvance getE19R8()
        {
            return E19R8;
        }
        public LevelAdvance getE19R9()
        {
            return E19R9;
        }
        public LevelAdvance getE19R10()
        {
            return E19R10;
        }
        public LevelAdvance getE19R11()
        {
            return E19R11;
        }
        public LevelAdvance getE19R12()
        {
            return E19R12;
        }
        public LevelAdvance getE19R13()
        {
            return E19R13;
        }

    }
}
