import { Component, Injector, AfterViewInit } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';
import { appModuleAnimation } from '@shared/animations/routerTransition';
//import { HttpClient } from '@angular/common/http';

@Component({
    templateUrl: './question.component.html',
    animations: [appModuleAnimation()]
})

export class QuestionComponent extends AppComponentBase implements AfterViewInit {

    public questionmodel: Question[];
    public cachequestionmodel: Question[];

    constructor(
        injector: Injector
    ) {
        super(injector);
    }

    ngAfterViewInit() {
    }

}

interface Question {
    userId: number;
    username: string;
    emailid: string;
    question: string;
    response: string;
}
