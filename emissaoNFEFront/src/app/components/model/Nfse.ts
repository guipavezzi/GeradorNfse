export interface INfse{
    nomePrestador: string
    cnpjPrestador: number
    inscricaoPrestador: string
    nomeTomador: string
    cnpjTomador: number
    inscricaoTomador: string
    numeroNota: number
    dataEmissao?: Date
    valor: string
    descricao: string
    localServico: string
}