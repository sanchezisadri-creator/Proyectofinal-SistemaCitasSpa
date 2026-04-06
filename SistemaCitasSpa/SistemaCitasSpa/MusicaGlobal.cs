using WMPLib;

namespace SistemaCitasSpa
{
    public static class MusicaGlobal
    {
        public static WindowsMediaPlayer reproductor = new WindowsMediaPlayer();

        public static bool estaSonando = false;

        public static void Iniciar()
        {
            reproductor.URL = "Bob-Marley-Could-You-Be-Loved-_HQ_.wav";
            reproductor.settings.setMode("loop", true);
            reproductor.controls.play();
            estaSonando = true;
        }

        public static void Detener()
        {
            reproductor.controls.stop();
            estaSonando = false;
        }

        public static void Pausar()
        {
            reproductor.controls.pause();
        }

        public static void Volumen(int valor)
        {
            reproductor.settings.volume = valor;
        }
    }
}