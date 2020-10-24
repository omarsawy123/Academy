import { Component, Input, OnInit, Output,EventEmitter } from '@angular/core';

@Component({
  selector: 'Year-filter',
  templateUrl: './filter.component.html',
  styleUrls: ['./filter.component.css']
})
export class YearFilterComponent {


  currentSelectedYear: string = "AllYears";

  // @Input()
  // AllYears:string

  // @Input()
  // FirstYear:string

  // @Input()
  // SecondYear:string

  // @Input()
  // ThirdYear:string

  // @Input()
  // FourthYear:string

  @Output()
  SelectedYearChanged :EventEmitter<string>=new EventEmitter<string>();

  OnselectChanged(){
    this.SelectedYearChanged.emit(this.currentSelectedYear);
    console.log(this.currentSelectedYear);
  }

}
