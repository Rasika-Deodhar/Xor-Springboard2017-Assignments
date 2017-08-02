import { Component } from '@angular/core';
import { RouterModule } from '@angular/router';
import { AdvertisementService } from './Services/AdvertisementService.Services';

@Component({
  selector: 'my-app',
  template: ` <navBar></navBar>
             
  <router-outlet></router-outlet>
  
  <br> <br>

  <footer class="container-fluid">
  
	<div style="text-align:center;"> 
		Follow us on-
	</div>

	<div class="footer-content" align="center"> 
		<a href="https://www.facebook.com"><img src="images/img2.jpg" style="width:70px;height:50px;"></a> &nbsp; &nbsp; &nbsp; &nbsp;
	    <a href="https://twitter.com"><img src="images/img3.jpg" style="width:70px;height:50px;"></a> &nbsp; &nbsp; &nbsp; &nbsp;
	    <a href="https://instagram.com"><img src="images/img4.jpg" style="width:70px;height:50px;"></a> &nbsp; &nbsp; &nbsp; &nbsp;
	    <a href="mailto:shopnsell@gmail.com"><img src="images/img5.jpg" style="width:70px;height:50px;"></a> &nbsp; &nbsp; &nbsp; &nbsp;
	</div>

</footer>`,
providers:[AdvertisementService]
})
export class AppComponent  { 
 ifLogin:boolean=false;
}
