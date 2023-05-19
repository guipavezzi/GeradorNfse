import { Component } from '@angular/core';
import { INfse } from '../model/Nfse';
import { NfseService } from 'src/app/services/nfse.service';
import { FormGroup } from '@angular/forms';

@Component({
  selector: 'app-form-emissao-nfe',
  templateUrl: './form-emissao-nfe.component.html',
  styleUrls: ['./form-emissao-nfe.component.scss']
})
export class FormEmissaoNfeComponent {
    ngOnInit(): void{
    }


  nfse: INfse = {
    nomePrestador: '',
    cnpjPrestador: '',
    inscricaoPrestador: '',
    nomeTomador: '',
    cnpjTomador: '',
    inscricaoTomador: '',
    numeroNota: 0,
    dataEmissao: undefined,
    valor: '',
    descricao: '',
    localServico: ''
  }



  constructor(private service: NfseService){}

  

  gerarXML(){
    this.service.returnXML(this.nfse).subscribe(
      response =>{
        console.log(response)
      }
    )
  }

}
