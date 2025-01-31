﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using UStart.Infrastructure.Context;

namespace UStart.Infrastructure.Migrations
{
    [DbContext(typeof(UStartContext))]
    [Migration("20210915231311_dominio-v1")]
    partial class dominiov1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("UStart.Domain.Entities.Cliente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<bool>("Ativo")
                        .HasColumnType("boolean")
                        .HasColumnName("ativo");

                    b.Property<string>("Bairro")
                        .HasColumnType("text")
                        .HasColumnName("bairro");

                    b.Property<string>("CEP")
                        .HasColumnType("text")
                        .HasColumnName("cep");

                    b.Property<string>("CNPJ")
                        .HasColumnType("text")
                        .HasColumnName("cnpj");

                    b.Property<string>("CPF")
                        .HasColumnType("text")
                        .HasColumnName("cpf");

                    b.Property<string>("CidadeId")
                        .HasColumnType("text")
                        .HasColumnName("cidade_id");

                    b.Property<string>("CidadeNome")
                        .HasColumnType("text")
                        .HasColumnName("cidade_nome");

                    b.Property<string>("CodigoExterno")
                        .HasColumnType("text")
                        .HasColumnName("codigo_externo");

                    b.Property<string>("Complemento")
                        .HasColumnType("text")
                        .HasColumnName("complemento");

                    b.Property<string>("Email")
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("Fone")
                        .HasColumnType("text")
                        .HasColumnName("fone");

                    b.Property<decimal>("LimiteDeCredito")
                        .HasColumnType("numeric")
                        .HasColumnName("limite_de_credito");

                    b.Property<string>("Nome")
                        .HasColumnType("text")
                        .HasColumnName("nome");

                    b.Property<string>("Numero")
                        .HasColumnType("text")
                        .HasColumnName("numero");

                    b.Property<string>("RazaoSocial")
                        .HasColumnType("text")
                        .HasColumnName("razao_social");

                    b.Property<string>("Rua")
                        .HasColumnType("text")
                        .HasColumnName("rua");

                    b.HasKey("Id")
                        .HasName("pk_cliente");

                    b.ToTable("cliente");
                });

            modelBuilder.Entity("UStart.Domain.Entities.FormaPagamento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("CodigoExterno")
                        .HasColumnType("text")
                        .HasColumnName("codigo_externo");

                    b.Property<decimal>("Desconto")
                        .HasColumnType("numeric")
                        .HasColumnName("desconto");

                    b.Property<string>("Descricao")
                        .HasColumnType("text")
                        .HasColumnName("descricao");

                    b.Property<ICollection<string>>("Dias")
                        .HasColumnType("jsonb")
                        .HasColumnName("dias");

                    b.HasKey("Id")
                        .HasName("pk_formas_pagamentos");

                    b.ToTable("formas_pagamentos");
                });

            modelBuilder.Entity("UStart.Domain.Entities.GrupoProduto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("CodigoExterno")
                        .HasColumnType("text")
                        .HasColumnName("codigo_externo");

                    b.Property<string>("Descricao")
                        .HasColumnType("text")
                        .HasColumnName("descricao");

                    b.HasKey("Id")
                        .HasName("pk_grupo_produtos");

                    b.ToTable("grupo_produtos");
                });

            modelBuilder.Entity("UStart.Domain.Entities.Orcamento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid>("ClienteId")
                        .HasColumnType("uuid")
                        .HasColumnName("cliente_id");

                    b.Property<DateTime>("DataOrcamento")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("data_orcamento");

                    b.Property<Guid>("FormaPagamentoId")
                        .HasColumnType("uuid")
                        .HasColumnName("forma_pagamento_id");

                    b.Property<string>("Observacao")
                        .HasColumnType("text")
                        .HasColumnName("observacao");

                    b.Property<decimal>("PrecoUnitario")
                        .HasColumnType("numeric")
                        .HasColumnName("preco_unitario");

                    b.Property<decimal>("QuantidadeDeItens")
                        .HasColumnType("numeric")
                        .HasColumnName("quantidade_de_itens");

                    b.Property<decimal>("TotalDesconto")
                        .HasColumnType("numeric")
                        .HasColumnName("total_desconto");

                    b.Property<decimal>("TotalItens")
                        .HasColumnType("numeric")
                        .HasColumnName("total_itens");

                    b.Property<decimal>("TotalProdutos")
                        .HasColumnType("numeric")
                        .HasColumnName("total_produtos");

                    b.Property<Guid>("UsuarioId")
                        .HasColumnType("uuid")
                        .HasColumnName("usuario_id");

                    b.HasKey("Id")
                        .HasName("pk_orcamento");

                    b.HasIndex("ClienteId")
                        .HasDatabaseName("ix_orcamento_cliente_id");

                    b.HasIndex("FormaPagamentoId")
                        .HasDatabaseName("ix_orcamento_forma_pagamento_id");

                    b.HasIndex("UsuarioId")
                        .HasDatabaseName("ix_orcamento_usuario_id");

                    b.ToTable("orcamento");
                });

            modelBuilder.Entity("UStart.Domain.Entities.OrcamentoItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<decimal>("Desconto")
                        .HasColumnType("numeric")
                        .HasColumnName("desconto");

                    b.Property<string>("Observacao")
                        .HasColumnType("text")
                        .HasColumnName("observacao");

                    b.Property<Guid>("OrcamentoId")
                        .HasColumnType("uuid")
                        .HasColumnName("orcamento_id");

                    b.Property<decimal>("PrecoUnitario")
                        .HasColumnType("numeric")
                        .HasColumnName("preco_unitario");

                    b.Property<Guid>("ProdutoId")
                        .HasColumnType("uuid")
                        .HasColumnName("produto_id");

                    b.Property<decimal>("Quantidade")
                        .HasColumnType("numeric")
                        .HasColumnName("quantidade");

                    b.Property<decimal>("TotalItem")
                        .HasColumnType("numeric")
                        .HasColumnName("total_item");

                    b.Property<decimal>("TotalUnitario")
                        .HasColumnType("numeric")
                        .HasColumnName("total_unitario");

                    b.HasKey("Id")
                        .HasName("pk_orcamento_item");

                    b.HasIndex("OrcamentoId")
                        .HasDatabaseName("ix_orcamento_item_orcamento_id");

                    b.HasIndex("ProdutoId")
                        .HasDatabaseName("ix_orcamento_item_produto_id");

                    b.ToTable("orcamento_item");
                });

            modelBuilder.Entity("UStart.Domain.Entities.Pedido", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid>("ClienteId")
                        .HasColumnType("uuid")
                        .HasColumnName("cliente_id");

                    b.Property<DateTime>("DataPedido")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("data_pedido");

                    b.Property<Guid>("FormaPagamentoId")
                        .HasColumnType("uuid")
                        .HasColumnName("forma_pagamento_id");

                    b.Property<string>("Observacao")
                        .HasColumnType("text")
                        .HasColumnName("observacao");

                    b.Property<decimal>("PrecoUnitario")
                        .HasColumnType("numeric")
                        .HasColumnName("preco_unitario");

                    b.Property<decimal>("QuantidadeDeItens")
                        .HasColumnType("numeric")
                        .HasColumnName("quantidade_de_itens");

                    b.Property<decimal>("TotalDesconto")
                        .HasColumnType("numeric")
                        .HasColumnName("total_desconto");

                    b.Property<decimal>("TotalItens")
                        .HasColumnType("numeric")
                        .HasColumnName("total_itens");

                    b.Property<decimal>("TotalProdutos")
                        .HasColumnType("numeric")
                        .HasColumnName("total_produtos");

                    b.Property<Guid>("UsuarioId")
                        .HasColumnType("uuid")
                        .HasColumnName("usuario_id");

                    b.HasKey("Id")
                        .HasName("pk_pedido");

                    b.HasIndex("ClienteId")
                        .HasDatabaseName("ix_pedido_cliente_id");

                    b.HasIndex("FormaPagamentoId")
                        .HasDatabaseName("ix_pedido_forma_pagamento_id");

                    b.HasIndex("UsuarioId")
                        .HasDatabaseName("ix_pedido_usuario_id");

                    b.ToTable("pedido");
                });

            modelBuilder.Entity("UStart.Domain.Entities.PedidoItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<decimal>("Desconto")
                        .HasColumnType("numeric")
                        .HasColumnName("desconto");

                    b.Property<string>("Observacao")
                        .HasColumnType("text")
                        .HasColumnName("observacao");

                    b.Property<Guid>("PedidoId")
                        .HasColumnType("uuid")
                        .HasColumnName("pedido_id");

                    b.Property<decimal>("PrecoUnitario")
                        .HasColumnType("numeric")
                        .HasColumnName("preco_unitario");

                    b.Property<Guid>("ProdutoId")
                        .HasColumnType("uuid")
                        .HasColumnName("produto_id");

                    b.Property<decimal>("Quantidade")
                        .HasColumnType("numeric")
                        .HasColumnName("quantidade");

                    b.Property<decimal>("TotalItem")
                        .HasColumnType("numeric")
                        .HasColumnName("total_item");

                    b.Property<decimal>("TotalUnitario")
                        .HasColumnType("numeric")
                        .HasColumnName("total_unitario");

                    b.HasKey("Id")
                        .HasName("pk_pedido_item");

                    b.HasIndex("PedidoId")
                        .HasDatabaseName("ix_pedido_item_pedido_id");

                    b.HasIndex("ProdutoId")
                        .HasDatabaseName("ix_pedido_item_produto_id");

                    b.ToTable("pedido_item");
                });

            modelBuilder.Entity("UStart.Domain.Entities.Produto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("CodigoExterno")
                        .HasColumnType("text")
                        .HasColumnName("codigo_externo");

                    b.Property<string>("Descricao")
                        .HasColumnType("text")
                        .HasColumnName("descricao");

                    b.Property<Guid>("GrupoProdutoId")
                        .HasColumnType("uuid")
                        .HasColumnName("grupo_produto_id");

                    b.Property<string>("Nome")
                        .HasColumnType("text")
                        .HasColumnName("nome");

                    b.Property<decimal>("Preco")
                        .HasColumnType("numeric")
                        .HasColumnName("preco");

                    b.Property<string>("UrlImagem")
                        .HasColumnType("text")
                        .HasColumnName("url_imagem");

                    b.HasKey("Id")
                        .HasName("pk_produtos");

                    b.HasIndex("GrupoProdutoId")
                        .HasDatabaseName("ix_produtos_grupo_produto_id");

                    b.ToTable("produtos");
                });

            modelBuilder.Entity("UStart.Domain.Entities.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<bool>("Ativo")
                        .HasColumnType("boolean")
                        .HasColumnName("ativo");

                    b.Property<string>("Autenticacao")
                        .HasColumnType("text")
                        .HasColumnName("autenticacao");

                    b.Property<DateTime>("DataRegistro")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("data_registro");

                    b.Property<string>("Email")
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("Nome")
                        .HasColumnType("text")
                        .HasColumnName("nome");

                    b.HasKey("Id")
                        .HasName("pk_usuarios");

                    b.ToTable("usuarios");
                });

            modelBuilder.Entity("UStart.Domain.Entities.Orcamento", b =>
                {
                    b.HasOne("UStart.Domain.Entities.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .HasConstraintName("fk_orcamento_cliente_cliente_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UStart.Domain.Entities.FormaPagamento", "FormaPagamento")
                        .WithMany()
                        .HasForeignKey("FormaPagamentoId")
                        .HasConstraintName("fk_orcamento_formas_pagamentos_forma_pagamento_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UStart.Domain.Entities.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .HasConstraintName("fk_orcamento_usuarios_usuario_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("FormaPagamento");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("UStart.Domain.Entities.OrcamentoItem", b =>
                {
                    b.HasOne("UStart.Domain.Entities.Orcamento", "Orcamento")
                        .WithMany("Itens")
                        .HasForeignKey("OrcamentoId")
                        .HasConstraintName("fk_orcamento_item_orcamento_orcamento_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UStart.Domain.Entities.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId")
                        .HasConstraintName("fk_orcamento_item_produtos_produto_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Orcamento");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("UStart.Domain.Entities.Pedido", b =>
                {
                    b.HasOne("UStart.Domain.Entities.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .HasConstraintName("fk_pedido_cliente_cliente_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UStart.Domain.Entities.FormaPagamento", "FormaPagamento")
                        .WithMany()
                        .HasForeignKey("FormaPagamentoId")
                        .HasConstraintName("fk_pedido_formas_pagamentos_forma_pagamento_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UStart.Domain.Entities.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .HasConstraintName("fk_pedido_usuarios_usuario_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("FormaPagamento");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("UStart.Domain.Entities.PedidoItem", b =>
                {
                    b.HasOne("UStart.Domain.Entities.Pedido", "Pedido")
                        .WithMany("Itens")
                        .HasForeignKey("PedidoId")
                        .HasConstraintName("fk_pedido_item_pedido_pedido_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UStart.Domain.Entities.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId")
                        .HasConstraintName("fk_pedido_item_produtos_produto_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pedido");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("UStart.Domain.Entities.Produto", b =>
                {
                    b.HasOne("UStart.Domain.Entities.GrupoProduto", "GrupoProduto")
                        .WithMany()
                        .HasForeignKey("GrupoProdutoId")
                        .HasConstraintName("fk_produtos_grupo_produtos_grupo_produto_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GrupoProduto");
                });

            modelBuilder.Entity("UStart.Domain.Entities.Orcamento", b =>
                {
                    b.Navigation("Itens");
                });

            modelBuilder.Entity("UStart.Domain.Entities.Pedido", b =>
                {
                    b.Navigation("Itens");
                });
#pragma warning restore 612, 618
        }
    }
}
