using System;
using System.Collections.Generic;

namespace Aula14
{
    class Program
    {
        static void Main(string[] args)
        {
            Licensa rwindols = new Licensa("Michaelsóft Rwildols", 699.90, "SUAA-HE52-W6WG-B8Y9");
            Licensa corehul  = new Licensa("Corehul Dreus", 2999.90, "XZLT-CXL9-SLHV-99UM");

            Assinatura alface123   = new Assinatura("Michaelsóft Alface", 39.90, 12, "5GNX-VM6Y-L6W8-SCPC");
            Assinatura cottonshopi = new Assinatura("Aldobo Cottonshopi", mensalidade: 89.90, 12, "H84A-8QDF-4XPT-A2WZ");
            Assinatura premillere  = new Assinatura("Aldobo Premillere", mensalidade: 89.90, 12, "RLBD-YTRZ-UPH7-VQGM");

            ProdutoFisico mausi    = new ProdutoFisico("Mausi Michaelsóft", 89.90, 12.99);
            ProdutoFisico lepetope = new ProdutoFisico("Lepetope Dehul", 3499.90, 123.45);

            Fornecedor abc = new Fornecedor("ABC Industrial", "13.256.859/0001-90");
            Fornecedor xyz = new Fornecedor("Grupo XYZ",      "58.568.888/0255-99");

            abc.AssociarProduto(mausi);
            xyz.AssociarProduto(rwindols);
            xyz.AssociarProduto(lepetope);

            Cliente hermenegildo = new Cliente("Hermenegildo Benevides", "123.456.789-10");
            Cliente zoroastra    = new Cliente("Zoroastra Muad'dib", "109.876.543-21");

            Carrinho carrinho = new Carrinho(); 
            carrinho.Adicionar(rwindols);
            carrinho.Adicionar(corehul);
            carrinho.Adicionar(alface123, 3);
            carrinho.Adicionar(cottonshopi);
            carrinho.Adicionar(premillere);
            carrinho.Adicionar(mausi, 3);
            carrinho.Adicionar(lepetope);

            Compra compra = new Compra(); 
            compra.ComprarItem(corehul, 1 );
            compra.ComprarItem(alface123, 3);

            compra.AdicionarItem(corehul);
            compra.AdicionarItem(alface123, 3);
            compra.AdicionarItem(premillere);

            Relatorio relatorioArtistico = new Relatorio("Relatorio Artístico",
                "Lista de todos os softwares artisticos vendidos na loja.");
            relatorioArtistico.AdicionarItem(cottonshopi);
            relatorioArtistico.AdicionarItem(premillere);
            relatorioArtistico.AdicionarItem(corehul);
            relatorioArtistico.ImprimirRelatorio();

            Relatorio relatorioFornecedores = new Relatorio("Relatório de Fornecedores",
                "Lista de todos os fornecedores e os produtos que fornecem.");
            relatorioFornecedores.AdicionarItem(abc);
            relatorioFornecedores.AdicionarItem(xyz);
            relatorioFornecedores.ImprimirRelatorio();
            
            Relatorio relatorioClientes = new Relatorio("Relatório de Clientes",
                "Lista de todos os clientes que compraram no mês de abril");
            relatorioClientes.AdicionarItem(hermenegildo);
            relatorioClientes.AdicionarItem(zoroastra);
            relatorioClientes.ImprimirRelatorio();

            carrinho.ImprimirCarrinho();

            compra.ImprimirCompra();
        }
    }
}