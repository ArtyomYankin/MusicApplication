import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { AppComponent } from './app.component';
import { ArtistPageComponent } from './artist-page/artist-page.component';
import { NotFoundComponent } from './not-found/not-found.component';
import { Routes, RouterModule } from '@angular/router';
import { DataService } from './data.service';
import { ArtistListComponent } from './artist-list/artist-list.component';
import { NavBarComponent } from './nav-bar/nav-bar.component';

const appRoutes: Routes = [
  { path: '', component: ArtistListComponent },
  { path: 'artist/:id', component: ArtistPageComponent },
  { path: '**', component: NotFoundComponent },
];
@NgModule({
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    RouterModule.forRoot(appRoutes),
  ],
  declarations: [
    AppComponent,
    ArtistPageComponent,
    NotFoundComponent,
    ArtistListComponent,
    NavBarComponent,
  ],
  bootstrap: [AppComponent, ArtistPageComponent, ArtistListComponent],
  providers: [DataService],
})
export class AppModule {}
