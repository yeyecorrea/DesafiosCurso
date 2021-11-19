using System;

namespace Desafio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Publicacion post1 = new Publicacion("Conociendo a persona", "Yeferson", true, "Aqui un prueba de un contenido");
            Console.WriteLine(post1);
            Publicacion post2 = new Publicacion("Personas asesinadas", "Juan", false, "En asia an asesinado a 30 personas por causas aun desconocidas");
            Console.WriteLine(post2);

            PublicacionImagen imagen1 = new PublicacionImagen("mi primera imagen", "yeferson", true, "https://imagen.com");
            Console.WriteLine(imagen1);

            PublicacionVideo video1 = new PublicacionVideo("Mi primer video", "juan", false, "https://video.com", 34);
            Console.WriteLine(video1);
            video1.Play();
            Console.WriteLine("Presiona cualquier tecla para parar la reproduccion");
            Console.ReadKey();
            video1.Stop();

        }
    }
}
