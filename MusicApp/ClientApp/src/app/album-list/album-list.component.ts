import { Component, OnInit } from "@angular/core";
import { DataService } from "../data.service";
import { Album } from "../album";
import { listLazyRoutes } from "@angular/compiler/src/aot/lazy_routes";

@Component({
  templateUrl: "./album-list.component.html",
  providers: [DataService],
  styleUrls: ["./album-list.component.css"],
})
export class AlbumListComponent implements OnInit {
  albums: Album[];
  artistId: number;
  artsitId = 6;
  constructor(private dataService: DataService) {}

  ngOnInit() {
    this.loadAlbums();
  }
  loadAlbums() {
    this.dataService
      .getAlbums(6)
      .subscribe((data: Album[]) => (this.albums = data));
  }
}
