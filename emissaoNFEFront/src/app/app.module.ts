import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser'
import { HttpClientModule } from '@angular/common/http';
import { AppComponent } from './app.component';
import { FormEmissaoNfeComponent } from './components/form-emissao-nfe/form-emissao-nfe.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NfseService } from './services/nfse.service';

@NgModule({
  declarations: [
    AppComponent,
    FormEmissaoNfeComponent,
  ],
  imports: [
    BrowserModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [NfseService],
  bootstrap: [AppComponent]
})
export class AppModule { }
