import { Component} from "@angular/core";

@Component({
    selector:'first-component',
    templateUrl:'./first.component.html'
})

export class FirstComponent{
    // greet:string="Hello";
    twowayvariable:string="Default Value";
    save(event)
    {
        console.log(event.target.value);
    }
}
