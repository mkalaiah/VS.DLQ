import { Component, Injector, AfterViewInit } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { RWeatherServiceProxy, WeatherDto } from '@shared/service-proxies/service-proxies';

@Component({
    templateUrl: './weather.component.html',
    animations: [appModuleAnimation()],
    providers: [RWeatherServiceProxy]
})

export class WeatherComponent extends AppComponentBase implements AfterViewInit {

    weatherDto: WeatherDto = new WeatherDto();

    constructor(
        injector: Injector,
        private _service: RWeatherServiceProxy
    ) {
        super(injector);
    }

    ngAfterViewInit(): void {
        this.getForecast();
    }

    getForecast(): void {
        this._service.getWeather("37.8136", "144.9631")
            .finally(() => {
            })
            .subscribe((result: WeatherDto) => {
                this.weatherDto = result;
            });
    }
}
