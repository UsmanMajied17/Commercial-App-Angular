import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { faTachometerAlt, faCopy, faTh, faTree, faChartPie} from '@fortawesome/free-solid-svg-icons';
@Component({
  selector: 'app-sidenav',
  templateUrl: './sidenav.component.html',
  styleUrls: ['./sidenav.component.css']
})
export class SidenavComponent implements OnInit {

 @Output()
 showBuyBte = new EventEmitter(false);

  constructor() { }
  faTachometerAlt = faTachometerAlt;
  faCopy = faCopy;
  faTh = faTh;
  faTree = faTree;
  faChartPie = faChartPie;
  ngOnInit(): void {
  }

  byeByteSelected(bte: string): void {
    console.log("bte",bte);
    if(bte === 'buy') {
      this.showBuyBte.emit(true);
    }
    else {
      this.showBuyBte.emit(false);
    }
  }

}
