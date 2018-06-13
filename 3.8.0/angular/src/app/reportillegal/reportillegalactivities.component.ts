import { Component, Injector, AfterViewInit } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';
import { appModuleAnimation } from '@shared/animations/routerTransition';
//import { HttpClient } from '@angular/common/http';

@Component({
    templateUrl: './reportillegalactivities.component.html',
    animations: [appModuleAnimation()]
})

export class ReportIllegalComponent extends AppComponentBase implements AfterViewInit {

    constructor(
        injector: Injector
    ) {
        super(injector);
    }

    ngAfterViewInit() {
    }

}
