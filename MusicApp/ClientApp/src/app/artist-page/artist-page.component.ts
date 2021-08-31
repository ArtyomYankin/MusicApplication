import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { DataService } from '../data.service';
import { Artist } from '../artist';
@Component({
  templateUrl: './artist-page.component.html',
  providers: [DataService],
  styleUrls: ['./artist-page.component.css'],
})
export class ArtistPageComponent implements OnInit {
  id: number;
  artist: Artist;
  loaded = false;
  constructor(private dataService: DataService, activeRoute: ActivatedRoute) {
    this.id = Number.parseInt(activeRoute.snapshot.params['id']);
  }

  ngOnInit() {
    if (this.id) {
      this.dataService.getArtist(this.id).subscribe((data: Artist) => {
        this.artist = data;
        this.loaded = true;
      });
    }
  }
}
