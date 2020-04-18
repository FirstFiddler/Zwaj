import { Component, OnInit } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';

@Component({
  selector: 'app-value',
  templateUrl: './value.component.html',
  styleUrls: ["./value.component.css"],
})
export class ValueComponent implements OnInit {
 vaules :  any;
  Uri : string = 'http://localhost:5000/api/Values/';
  constructor(private http: HttpClient) {}
  ngOnInit() {

    this.GetValue();
  }
  GetValue() {
    // let headers = new Headers();
    // headers.append('Content-Type', 'application/json');
    // headers.append('id', '1');
    // let params = new URLSearchParams();
    // params.append("someParamKey", this.someParamValue)
    let params = new HttpParams().set("id","1");
    this.http.get(this.Uri).subscribe(
      (respose) => {
        this.vaules = respose;
        console.log(respose);
      },
      (error) => {
        console.log(error);
      }
    );
  }
}
