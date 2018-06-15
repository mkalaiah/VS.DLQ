import { Component, Injector, AfterViewInit } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { SpeciesServiceProxy, ListResultDtoOfSpeciesDto, SpeciesDto } from '@shared/service-proxies/service-proxies';

@Component({
    templateUrl: './species.component.html',
    animations: [appModuleAnimation()]
})

export class SpeciesComponent extends AppComponentBase implements AfterViewInit {

    species: SpeciesDto[] = [];

    constructor(
        injector: Injector,
        private _service: SpeciesServiceProxy
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
            .subscribe((result: ListResultDtoOfSpeciesDto) => {
                this.species = result.items;
            });
    }
}
