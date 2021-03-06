import { Component, Injector, AfterViewInit, ViewChild, ElementRef } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { ReportIssueServiceProxy, CreateReportIssueDto } from '@shared/service-proxies/service-proxies';

@Component({
    templateUrl: './reportissue.component.html',
    animations: [appModuleAnimation()]
})

export class ReportIssueComponent extends AppComponentBase implements AfterViewInit {

    @ViewChild('cardBody') cardBody: ElementRef;

    model: CreateReportIssueDto = new CreateReportIssueDto();

    saving: boolean = false;

    constructor(
        injector: Injector,
        private _service: ReportIssueServiceProxy
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
        this._service.create(this.model)
            .finally(() => { this.saving = false; })
            .subscribe((result: string) => {
                if (result.match('success')) {
                    this.notify.success(this.l('SuccessfullySubmitted'));
                    return;
                }

            });
    }
}
