import { Component, Injector, AfterViewInit } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { RulesServiceProxy, ListResultDtoOfRuleDto, RuleDto } from '@shared/service-proxies/service-proxies';

@Component({
    templateUrl: './rules.component.html',
    animations: [appModuleAnimation()]
})

export class RulesComponent extends AppComponentBase implements AfterViewInit {

    rules: RuleDto[] = [];

    constructor(
        injector: Injector,
        private _service: RulesServiceProxy
    ) {
        super(injector);
    }

    ngAfterViewInit(): void {
        this.list();
    }

    list(): void {
        this._service.getAll()
            .finally(() => {
            })
            .subscribe((result: ListResultDtoOfRuleDto) => {
                this.rules = result.items;
            });
    }
}
