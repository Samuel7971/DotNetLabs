using DotNetLabs.Shared.Laboratorios.Enums;

namespace DotNetLabs.Shared.Laboratorios.Documentacao
{
    public static class CategoriaDocumentoExtensions
    {
        public static string Descricao(this CategoriaDocumento categoria)
        {
            return categoria switch
            {
                CategoriaDocumento.DotNetLabs => "DotNetLabs",
                CategoriaDocumento.Componentes => "Biblioteca de Componentes",
                CategoriaDocumento.Desenvolvimento => "Desenvolvimento",
                CategoriaDocumento.Qualidade => "QA e Testes",
                CategoriaDocumento.ProdutoProcessos => "Produto e Processos",
                _ => categoria.ToString()
            };
        }

        public static string Slug(this CategoriaDocumento categoria)
        {
            return categoria switch
            {
                CategoriaDocumento.DotNetLabs => "dotnetlabs",
                CategoriaDocumento.Componentes => "componentes",
                CategoriaDocumento.Desenvolvimento => "desenvolvimento",
                CategoriaDocumento.Qualidade => "qualidade",
                CategoriaDocumento.ProdutoProcessos => "produto-processos",
                _ => categoria.ToString().ToLowerInvariant()
            };
        }

        public static string Icone(this CategoriaDocumento categoria)
        {
            return categoria switch
            {
                CategoriaDocumento.DotNetLabs => "bi bi-bezier2",
                CategoriaDocumento.Componentes => "bi bi-boxes",
                CategoriaDocumento.Desenvolvimento => "bi bi-code-square",
                CategoriaDocumento.Qualidade => "bi bi-bug",
                CategoriaDocumento.ProdutoProcessos => "bi bi-kanban",
                _ => "bi bi-file-earmark-text"
            };
        }
    }
}
