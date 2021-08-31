import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Artist } from "./artist";

@Injectable()
export class DataService {
  private url = "/api/artists";

  constructor(private http: HttpClient) {}

  getArtists() {
    return this.http.get(this.url);
  }

  getArtist(id: number) {
    return this.http.get(this.url + "/" + id);
  }
}
