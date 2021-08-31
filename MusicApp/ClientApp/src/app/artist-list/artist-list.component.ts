import { Component, OnInit } from "@angular/core";
import { DataService } from "../data.service";
import { Artist } from "../artist";
import { listLazyRoutes } from "@angular/compiler/src/aot/lazy_routes";

@Component({
  templateUrl: "./artist-list.component.html",
  providers: [DataService],
  styleUrls: ["./artist-list.component.css"],
})
export class ArtistListComponent implements OnInit {
  artists: Artist[];

  constructor(private dataService: DataService) {}

  ngOnInit() {
    this.loadArtists();
  }
  loadArtists() {
    this.dataService
      .getArtists()
      .subscribe((data: Artist[]) => (this.artists = data));
  }
}
