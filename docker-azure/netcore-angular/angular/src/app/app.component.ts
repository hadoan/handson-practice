import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';


import { environment } from './../environments/environment';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
 
  constructor(private http: HttpClient) { }
  
  title = 'angular';
  webApiHello="hello";

  ngOnInit(): void {
    this.http.get(environment.web_url + "/api/values").subscribe((s)=>{
      console.log(s);
      this.webApiHello = s.toString();
    });
  }
}
