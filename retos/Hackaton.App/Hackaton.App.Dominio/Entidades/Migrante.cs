using System;
namespace Hackaton.App.Dominio{
    public class Migrante {
        public int MigranteId{get;set;}
        public string nombre{get;set;}
        public string apellido{get;set;}
        public TipoId tipoId{get;set;}
        public uint identificacion{get;set;}
        public string paisOrigen{get;set;}
        public DateTime fechaNacimiento{get;set;}
        public string correoE{get;set;}
        public uint telefono{get;set;}
        public string direcion {get;set;}
        public string ciudad {get;set;}
        public SituacionLaboral sitLaboral {get;set;}
    }
}