﻿using System;
using Estudiantes.Interface;
using Estudiantes.Entidad;
using System.Diagnostics.CodeAnalysis;

namespace Estudiantes.Inplementacion
{
    public class EstudianteMallaNueva : Estudiante, IEstudiante, IEquatable<EstudianteMallaNueva>
    {
        public string Matricular()
        {
            return "Me voy a matricular Online";
        }
        public string RecibirClases()
        {
            return "Estoy recibiendo clases Online";
        }
        public string HacerDeberes()
        {
            return "Estoy haciendo deberes en mi Laptop";
        }
        public string Estudiar()
        {
            return "Estoy estudiando en mi casa";
        }
        public string DarExamen()
        {
            return "Voy a dar el exámen Online";
        }

        public string TrabajarEmpresa()
        {
            return "Estoy trabajando en la empresa de manera Oline";
        }

        public string RecibirTrabajos()
        {
            return "Estoy recibiendo los trabajos mediante una plataforma privada";
        }

        public string HacerTrabajos()
        {
            return "Estoy realizando los trabajos con programas Online";
        }
        public string Leer()
        {
            return "Estoy leyendo para prepararme para la siguiente clase Online";
        }

        public string IrClaces()
        {
            return "Estoy asistiendo a las clases Virtuales para no tender ninguna falta";
        }

        public string PonerAtencion()
        {
            return "Estoy poniendo atención en las clases Virtuales";
        }

        public string Participar()
        {
            return "Estoy participando  en las video llamadas para sacar buenas notas";
        }

        public string Dialogar()
        {
            return "Estoy dialogando en las video llamadas cuando el Ingeniero pregunta";
        }

        public bool Equals([AllowNull] EstudianteMallaNueva other)
        {
            return this.Id == other.Id;
        }

    }
}


