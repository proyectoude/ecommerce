﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    public class Persona : Cliente
    {
        // Atributes
        public int cedula;

        // Properties
        public int Cedula { get { return cedula; } }
        public string Nombre { get; set; }

        // Constructores
        public Persona(int ci, string nom, String dir, string tel, int id, string mail, string pass, Boolean activo) : base(dir, tel, id, mail, pass, activo)
        {
            cedula = ci;
            Nombre = nom;
        }
    }
}