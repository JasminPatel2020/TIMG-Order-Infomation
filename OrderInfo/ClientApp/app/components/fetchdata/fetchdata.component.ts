import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'fetchdata',
    templateUrl: './fetchdata.component.html'
})
export class FetchDataComponent {
    public forecasts: WeatherForecast[];
    public cacheForecasts: WeatherForecast[];
    public summaries: Summary[];


    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        http.get(baseUrl + 'api/SampleData/WeatherForecasts').subscribe(result => {
            this.forecasts = result.json() as WeatherForecast[];
            this.cacheForecasts = result.json() as WeatherForecast[];
        }, error => console.error(error));

        http.get(baseUrl + 'api/SampleData/GetSummaries').subscribe(result => {
            this.summaries = result.json() as Summary[];
        }, error => console.error(error));
    }

    filterForeCasts(filterVal: any) {
        if (filterVal == "0")
            this.forecasts = this.cacheForecasts;
        else
            this.forecasts = this.cacheForecasts.filter((item) => item.summary == filterVal);
    }
}

interface WeatherForecast {
    dateFormatted: string;
    temperatureC: number;
    temperatureF: number;
    summary: string;
}

interface Summary {
    name: string;
}