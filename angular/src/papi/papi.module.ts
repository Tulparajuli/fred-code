import { NgModule } from "@angular/core";
import { PapiComponent } from "./papi.component";
import { PapiService } from "./papi.service";
import { HttpClientModule } from "@angular/common/http/";

@NgModule({
  declarations: [
    PapiComponent
  ],
  imports: [HttpClientModule],
  providers: [PapiService],
  bootstrap: []
})
export class PapiModule {}
