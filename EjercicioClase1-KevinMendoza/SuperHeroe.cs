

namespace EjercicioClase1_KevinMendoza
{
    public class SuperHeroe
    {
        public string NombreH { get; set; }
        public string IdentidadSecreta { get; set; }
        public string Ciudad { get; set; }
        public bool PuedeVolar { get; set; }


        public SuperPoder poder { get; set; }
        public SuperHeroe()
        {

            poder = new SuperPoder();
        }


        public void imprimir() {
            Console.WriteLine($"Nombre : {NombreH}");
            Console.WriteLine($"Identidad Secreta : {IdentidadSecreta}");
            Console.WriteLine($"Ciudad : {Ciudad}");
            Console.WriteLine($"Puede Volar? : {PuedeVolar}");
            Console.WriteLine($"Poder : {poder.NombreP}");
            Console.WriteLine($"Descripcion : {poder.descripcion}");
            Console.WriteLine($"Nivel : {poder.nivel}");

        }
    }
}
