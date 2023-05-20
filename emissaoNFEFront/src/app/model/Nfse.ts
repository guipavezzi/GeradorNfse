export interface INfse {
    nomePrestador: string
    cnpjPrestador: string
    inscricaoPrestador: string
    nomeTomador: string
    cnpjTomador: string
    inscricaoTomador: string
    numeroNota: number
    dataEmissao?: Date
    valor: string
    descricao: string
    localServico: string
  }