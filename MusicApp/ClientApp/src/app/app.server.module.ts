import { NgModule } from "@angular/core";
import { ServerModule } from "@angular/platform-server";
import { ModuleMapLoaderModule } from "@nguniversal/module-map-ngfactory-loader";
import { AppComponent } from "./app.component";
import { AppModule } from "./app.module";
import { ArtistListComponent } from "./artist-list/artist-list.component";
import { ArtistPageComponent } from "./artist-page/artist-page.component";

@NgModule({
  imports: [AppModule, ServerModule, ModuleMapLoaderModule],
  bootstrap: [AppComponent, ArtistPageComponent, ArtistListComponent],
})
export class AppServerModule {}
