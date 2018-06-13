import { Component, Injector, AfterViewInit, ViewChild, ElementRef } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { QuestionServiceProxy, QuestionInput, QuestionOutput } from '@shared/service-proxies/service-proxies';
//import { HttpClient } from '@angular/common/http';

@Component({
    templateUrl: './question.component.html',
    animations: [appModuleAnimation()]
})

export class QuestionComponent extends AppComponentBase implements AfterViewInit {

    @ViewChild('cardBody') cardBody: ElementRef;

    model: QuestionInput = new QuestionInput();

    saving: boolean = false;

    constructor(
        injector: Injector,
        private _questionService: QuestionServiceProxy
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
        this.model.emailAddress = this.appSession.user.emailAddress;
        this._questionService.submit(this.model)
            .finally(() => { this.saving = false; })
            .subscribe((result: QuestionOutput) => {
                if (result.message.match('success')) {
                    this.notify.success(this.l('SuccessfullySubmitted'));
                    return;
                }

            });
    }
}
