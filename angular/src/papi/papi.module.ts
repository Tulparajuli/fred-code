import { NgModule } from "@angular/core";
import { PapiComponent } from "./papi.component";
import { PapiService } from "./papi.service";
import { HttpClientModule } from "@angular/common/http/";
import { PapiRoutingModule } from "./papi.module.routing";

@NgModule({
  declarations: [
    PapiComponent
  ],
  imports: [
    HttpClientModule, PapiRoutingModule
  ],
  providers: [
    PapiService
  ]
})
export class PapiModule {}
