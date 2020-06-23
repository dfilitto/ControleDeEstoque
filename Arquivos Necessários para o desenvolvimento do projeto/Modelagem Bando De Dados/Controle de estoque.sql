
CREATE TABLE [categoria]
( 
	[cat_cod]            int  NOT NULL  IDENTITY ( 1,1 ) ,
	[cat_nome]           varchar(95)  NULL 
)
go

ALTER TABLE [categoria]
	ADD CONSTRAINT [XPKcategoria] PRIMARY KEY  NONCLUSTERED ([cat_cod] ASC)
go

CREATE TABLE [cliente]
( 
	[cli_cod]            int  NOT NULL  IDENTITY ( 1,1 ) ,
	[cli_nome]           varchar(95)  NULL ,
	[cli_cpfcnpj]        varchar(95)  NULL ,
	[cli_rgie]           varchar(95)  NULL ,
	[cli_rsocial]        varchar(95)  NULL ,
	[cli_tipo]           varchar(20)  NULL ,
	[cli_cep]            varchar(20)  NULL ,
	[cli_endereco]       varchar(95)  NULL ,
	[cli_bairro]         varchar(95)  NULL ,
	[cli_fone]           varchar(95)  NULL ,
	[cli_cel]            varchar(95)  NULL ,
	[cli_email]          varchar(95)  NULL ,
	[cli_endnumero]      varchar(10)  NULL ,
	[cli_cidade]         char(18)  NULL ,
	[cli_estado]         char(18)  NULL 
)
go

ALTER TABLE [cliente]
	ADD CONSTRAINT [XPKcliente] PRIMARY KEY  NONCLUSTERED ([cli_cod] ASC)
go

CREATE TABLE [compra]
( 
	[com_cod]            int  NOT NULL  IDENTITY ( 1,1 ) ,
	[com_data]           datetime  NULL ,
	[com_nfiscal]        int  NULL ,
	[com_total]          money  NULL ,
	[com_nparcelas]      int  NULL ,
	[com_status]         varchar(95)  NULL ,
	[for_cod]            int  NULL ,
	[tpa_cod]            int  NULL 
)
go

ALTER TABLE [compra]
	ADD CONSTRAINT [XPKcompra] PRIMARY KEY  NONCLUSTERED ([com_cod] ASC)
go

CREATE TABLE [fornecedor]
( 
	[for_cod]            int  NOT NULL  IDENTITY ( 1,1 ) ,
	[for_nome]           varchar(95)  NULL ,
	[for_rsocial]        varchar(95)  NULL ,
	[for_ie]             varchar(95)  NULL ,
	[for_cnpj]           varchar(95)  NULL ,
	[for_cep]            varchar(95)  NULL ,
	[for_endereco]       varchar(95)  NULL ,
	[for_bairro]         varchar(95)  NULL ,
	[for_fone]           varchar(95)  NULL ,
	[for_cel]            varchar(95)  NULL ,
	[for_email]          varchar(95)  NULL ,
	[for_endnumero]      varchar(95)  NULL ,
	[for_cidade]         varchar(95)  NULL ,
	[for_estado]         varchar(95)  NULL 
)
go

ALTER TABLE [fornecedor]
	ADD CONSTRAINT [XPKfornecedor] PRIMARY KEY  NONCLUSTERED ([for_cod] ASC)
go

CREATE TABLE [itenscompra]
( 
	[itc_cod]            int  NOT NULL ,
	[itc_qtde]           float  NULL ,
	[itc_valor]          money  NULL ,
	[com_cod]            int  NOT NULL ,
	[pro_cod]            int  NOT NULL 
)
go

ALTER TABLE [itenscompra]
	ADD CONSTRAINT [XPKitenscompra] PRIMARY KEY  NONCLUSTERED ([itc_cod] ASC,[com_cod] ASC,[pro_cod] ASC)
go

CREATE TABLE [itensvenda]
( 
	[itv_cod]            int  NOT NULL ,
	[itv_qtde]           float  NULL ,
	[itv_valor]          money  NULL ,
	[ven_cod]            int  NOT NULL ,
	[pro_cod]            int  NOT NULL 
)
go

ALTER TABLE [itensvenda]
	ADD CONSTRAINT [XPKitensVenda] PRIMARY KEY  NONCLUSTERED ([itv_cod] ASC,[ven_cod] ASC,[pro_cod] ASC)
go

CREATE TABLE [parcelascompra]
( 
	[pco_cod]            int  NOT NULL ,
	[pco_valor]          money  NULL ,
	[pco_datapagto]      date  NULL ,
	[pco_datavecto]      date  NULL ,
	[com_cod]            int  NOT NULL 
)
go

ALTER TABLE [parcelascompra]
	ADD CONSTRAINT [XPKparcelascompra] PRIMARY KEY  CLUSTERED ([pco_cod] ASC,[com_cod] ASC)
go

CREATE TABLE [parcelasvenda]
( 
	[ven_cod]            int  NOT NULL ,
	[pve_cod]            int  NOT NULL ,
	[pve_valor]          money  NULL ,
	[pve_datapagto]      date  NULL ,
	[pve_datavecto]      date  NULL 
)
go

ALTER TABLE [parcelasvenda]
	ADD CONSTRAINT [XPKparcelasvenda] PRIMARY KEY  CLUSTERED ([ven_cod] ASC,[pve_cod] ASC)
go

CREATE TABLE [produto]
( 
	[pro_cod]            int  NOT NULL  IDENTITY ( 1,1 ) ,
	[pro_nome]           varchar(95)  NULL ,
	[pro_descricao]      text  NULL ,
	[pro_foto]           image  NULL ,
	[pro_valorpago]      money  NULL ,
	[pro_valorvenda]     money  NULL ,
	[pro_qtde]           float  NULL ,
	[umed_cod]           int  NULL ,
	[cat_cod]            int  NULL ,
	[scat_cod]           int  NULL 
)
go

ALTER TABLE [produto]
	ADD CONSTRAINT [XPKproduto] PRIMARY KEY  NONCLUSTERED ([pro_cod] ASC)
go

CREATE TABLE [subcategoria]
( 
	[scat_cod]           int  NOT NULL  IDENTITY ( 1,1 ) ,
	[scat_nome]          varchar(95)  NULL ,
	[cat_cod]            int  NULL 
)
go

ALTER TABLE [subcategoria]
	ADD CONSTRAINT [XPKsubcategoria] PRIMARY KEY  NONCLUSTERED ([scat_cod] ASC)
go

CREATE TABLE [tipopagamento]
( 
	[tpa_cod]            int  NOT NULL  IDENTITY ( 1,1 ) ,
	[tpa_nome]           varchar(90)  NULL 
)
go

ALTER TABLE [tipopagamento]
	ADD CONSTRAINT [XPKtipopagamento] PRIMARY KEY  CLUSTERED ([tpa_cod] ASC)
go

CREATE TABLE [undmedida]
( 
	[umed_cod]           int  NOT NULL  IDENTITY ( 1,1 ) ,
	[umed_nome]          varchar(95)  NULL 
)
go

ALTER TABLE [undmedida]
	ADD CONSTRAINT [XPKmedida] PRIMARY KEY  NONCLUSTERED ([umed_cod] ASC)
go

CREATE TABLE [venda]
( 
	[ven_cod]            int  NOT NULL  IDENTITY ( 1,1 ) ,
	[ven_data]           datetime  NULL ,
	[ven_nfiscal]        int  NULL ,
	[ven_total]          money  NULL ,
	[ven_nparcelas]      int  NULL ,
	[ven_status]         varchar(95)  NULL ,
	[cli_cod]            int  NULL ,
	[tpa_cod]            int  NULL ,
	[ven_avista]         integer  NULL 
)
go

ALTER TABLE [venda]
	ADD CONSTRAINT [XPKvenda] PRIMARY KEY  NONCLUSTERED ([ven_cod] ASC)
go


ALTER TABLE [compra]
	ADD CONSTRAINT [R_21] FOREIGN KEY ([for_cod]) REFERENCES [fornecedor]([for_cod])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [compra]
	ADD CONSTRAINT [R_24] FOREIGN KEY ([tpa_cod]) REFERENCES [tipopagamento]([tpa_cod])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE [itenscompra]
	ADD CONSTRAINT [R_15] FOREIGN KEY ([com_cod]) REFERENCES [compra]([com_cod])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [itenscompra]
	ADD CONSTRAINT [R_17] FOREIGN KEY ([pro_cod]) REFERENCES [produto]([pro_cod])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE [itensvenda]
	ADD CONSTRAINT [R_13] FOREIGN KEY ([ven_cod]) REFERENCES [venda]([ven_cod])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [itensvenda]
	ADD CONSTRAINT [R_14] FOREIGN KEY ([pro_cod]) REFERENCES [produto]([pro_cod])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE [parcelascompra]
	ADD CONSTRAINT [R_25] FOREIGN KEY ([com_cod]) REFERENCES [compra]([com_cod])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE [parcelasvenda]
	ADD CONSTRAINT [R_22] FOREIGN KEY ([ven_cod]) REFERENCES [venda]([ven_cod])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE [produto]
	ADD CONSTRAINT [R_9] FOREIGN KEY ([umed_cod]) REFERENCES [undmedida]([umed_cod])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [produto]
	ADD CONSTRAINT [R_11] FOREIGN KEY ([cat_cod]) REFERENCES [categoria]([cat_cod])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [produto]
	ADD CONSTRAINT [R_12] FOREIGN KEY ([scat_cod]) REFERENCES [subcategoria]([scat_cod])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE [subcategoria]
	ADD CONSTRAINT [R_10] FOREIGN KEY ([cat_cod]) REFERENCES [categoria]([cat_cod])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE [venda]
	ADD CONSTRAINT [R_20] FOREIGN KEY ([cli_cod]) REFERENCES [cliente]([cli_cod])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [venda]
	ADD CONSTRAINT [R_23] FOREIGN KEY ([tpa_cod]) REFERENCES [tipopagamento]([tpa_cod])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go
