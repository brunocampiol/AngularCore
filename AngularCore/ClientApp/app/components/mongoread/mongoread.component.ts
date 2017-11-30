import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'mongoread',
    templateUrl: './mongoread.component.html'
})
export class MongoReadComponent {
    public mongorows: MongoRow[];

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        http.get(baseUrl + 'Mongo/GetFixedMongoRows').subscribe(result => {
            this.mongorows = result.json() as MongoRow[];
        }, error => console.error(error));
    }
}

interface MongoRow {
    id: number;
    value: string;
}
