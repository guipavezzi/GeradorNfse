import { Component } from '@angular/core';
import { INfse } from '../model/Nfse';

@Component({
  selector: 'app-form-emissao-nfe',
  templateUrl: './form-emissao-nfe.component.html',
  styleUrls: ['./form-emissao-nfe.component.scss']
})
export class FormEmissaoNfeComponent {


  nfse: INfse = {
    nomePrestador: '',
    cnpjPrestador: 0,
    inscricaoPrestador: '',
    nomeTomador: '',
    cnpjTomador: 0,
    inscricaoTomador: '',
    numeroNota: 0,
    dataEmissao: undefined,
    valor: '',
    descricao: '',
    localServico: ''
  }

  gerarXML(){
    console.log(this.nfse)
  }

}
