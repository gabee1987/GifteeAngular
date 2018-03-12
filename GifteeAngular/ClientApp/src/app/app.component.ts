import { Component } from '@angular/core';
import { ToastyService, ToastyConfig, ToastOptions, ToastData } from 'ng2-toasty';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  constructor(private toastyService: ToastyService, private toastyConfig: ToastyConfig) {
    // Assign the selected theme name to the `theme` property of the instance of ToastyConfig.  
    // Possible values: default, bootstrap, material 
    this.toastyConfig.theme = 'bootstrap';
  }

  title = 'Giftee';

  

}
