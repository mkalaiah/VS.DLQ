import { Component, Injector, AfterViewInit, ViewChild, ElementRef } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { ReportIllegalServiceProxy, ReportIllegalInput, ReportOutput } from '@shared/service-proxies/service-proxies';
//import { HttpClient } from '@angular/common/http';

@Component({
    templateUrl: './reportillegalactivities.component.html',
    animations: [appModuleAnimation()]
})

export class ReportIllegalComponent extends AppComponentBase implements AfterViewInit {

    @ViewChild('cardBody') cardBody: ElementRef;

    model: ReportIllegalInput = new ReportIllegalInput();

    saving: boolean = false;

    constructor(
        injector: Injector,
        private _questionService: ReportIllegalServiceProxy
    ) {
        super(injector);
    }

    ngAfterViewInit() {
        $(this.cardBody.nativeElement).find('input:first').focus();
    }

    save(): void {
        this.saving = true;
        this.model.userId = this.appSession.userId;
        this.model.userName = this.appSession.user.name;
        this._questionService.submit(this.model)
            .finally(() => { this.saving = false; })
            .subscribe((result: ReportOutput) => {
                if (!result.message.match('success')) {
                    this.notify.success(this.l('SuccessfullySubmitted'));
                    return;
                }

            });
    }
}
