import { Component, ViewChild } from '@angular/core';
import { INfse } from '../../model/Nfse';
import { NfseService } from 'src/app/services/nfse.service';
import { BsModalService, BsModalRef } from 'ngx-bootstrap/modal';
import { DomSanitizer, SafeHtml } from '@angular/platform-browser';

@Component({
  selector: 'app-form-emissao-nfe',
  templateUrl: './form-emissao-nfe.component.html',
  styleUrls: ['./form-emissao-nfe.component.scss']
})
export class FormEmissaoNfeComponent {
    ngOnInit(): void{
    }

    xmlData: SafeHtml = '';
    modalOpened: boolean = false;


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

  constructor(private service: NfseService, modalRef: BsModalRef, private sanitizer: DomSanitizer){

  }

 gerarXML() {
  this.service.returnXML(this.nfse).subscribe(
    response => {
      console.log(response)
      this.xmlData = response
    }
  );
}

}
