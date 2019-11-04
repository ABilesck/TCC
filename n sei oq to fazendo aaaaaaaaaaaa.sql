SELECT        tcc_Servico.IDMecanico, tcc_Mecanico.razaoSocial, tcc_Mecanico.contaBancaria, tcc_Mecanico.agenciaBancaria, tcc_Servico.IDOrcamento, tcc_Orcamento.MaoDeObra, tcc_produtoOrcamento.IDProduto, tcc_Produto.descricao, 
                         tcc_produtoOrcamento.quantidade, tcc_produtoOrcamento.precoUnitario, tcc_produtoOrcamento.quantidade * tcc_produtoOrcamento.precoUnitario AS SubTotal, tcc_Orcamento.IDAutomovel, tcc_Automovel.modelo, 
                         tcc_Automovel.IDCliente, tcc_Cliente.nome
FROM            tcc_Servico INNER JOIN
                         tcc_produtoOrcamento ON tcc_Servico.IDOrcamento = tcc_produtoOrcamento.IDOrcamento INNER JOIN
                         tcc_Produto ON tcc_produtoOrcamento.IDProduto = tcc_Produto.IDProduto INNER JOIN
                         tcc_Orcamento ON tcc_Servico.IDOrcamento = tcc_Orcamento.IDOrcamento INNER JOIN
                         tcc_Mecanico ON tcc_Servico.IDMecanico = tcc_Mecanico.IDMecanico INNER JOIN
                         tcc_Automovel ON tcc_Orcamento.IDAutomovel = tcc_Automovel.IDAutomovel INNER JOIN
                         tcc_Cliente ON tcc_Automovel.IDCliente = tcc_Cliente.IDCliente