import { Injectable } from '@angular/core';
import { INfse } from '../model/Nfse';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class NfseService {

  private url = "https://localhost:7050/NFSe"

  constructor(private HtpClient: HttpClient) { }

   httpOptions = {
    responseType: 'text' as 'json'  // Indica que a resposta é uma string
  };

  returnXML(infse: INfse): Observable<string>{
    return this.HtpClient.post<string>(this.url, infse, this.httpOptions)
  }
}
