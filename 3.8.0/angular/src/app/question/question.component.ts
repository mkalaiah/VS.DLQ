import { Component, Injector, AfterViewInit, ViewChild, ElementRef } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { QueryServiceProxy, CreateQueryDto } from '@shared/service-proxies/service-proxies';

@Component({
    templateUrl: './question.component.html',
    animations: [appModuleAnimation()]
})

export class QuestionComponent extends AppComponentBase implements AfterViewInit {

    @ViewChild('cardBody') cardBody: ElementRef;

    model: CreateQueryDto = new CreateQueryDto();

    saving: boolean = false;

    constructor(
        injector: Injector,
        private _questionService: QueryServiceProxy
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
        this.model.emailId = this.appSession.user.emailAddress;
        this._questionService.create(this.model)
            .finally(() => { this.saving = false; })
            .subscribe((result: string) => {
                if (result.match('success')) {
                    this.notify.success(this.l('SuccessfullySubmitted'));
                    return;
                }

            });
    }
}
