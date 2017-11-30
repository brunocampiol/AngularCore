import { Component } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'formsubmit',
    templateUrl: './formsubmit.component.html'
})
export class FormSubmitComponent {

    public weather: FormSubmitComponent;

    constructor(private http: Http) {
    }

    public getSampleWeather() {
        this.http.get('http://localhost:50000/sample/getsampleweather/').subscribe(result => {
            this.weather = result.json();
        });
    }

    //public getWeather(chosenCity: string) {
    //    this.http.get('http://localhost:50000/samplecontroller/getweather/' + chosenCity).subscribe(result => {
    //        this.weather = result.json();
    //    });
    //}

    //getUsers() {
    //    return this._http.get(`http://localhost:53629/GetUsers2`)
    //        .map((res: Response) => res.json());
    //} 
}
