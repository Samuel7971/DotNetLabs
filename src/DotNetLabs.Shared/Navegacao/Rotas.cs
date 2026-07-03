namespace DotNetLabs.Shared.Navegacao
{
    public static class Rotas
    {
        public const string Home = "/";
        public const string Laboratorios = "/laboratorios";

        public static string Laboratorio(string id)
            => $"{Laboratorios}/{id}";
    }
}
