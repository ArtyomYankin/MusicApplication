import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Artist } from "./artist";
import { Album } from "./album";

@Injectable()
export class DataService {
  private url = "/api/artists";
  private alUrl = "/api/albums";
  constructor(private http: HttpClient) {}

  getArtists() {
    return this.http.get(this.url);
  }

  getArtist(id: number) {
    return this.http.get(this.url + "/" + id);
  }
  getAlbums(artistId: number) {
    return this.http.get(this.alUrl + "/" + artistId);
  }
}
