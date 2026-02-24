import { CUSTOM_ELEMENTS_SCHEMA, NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CharacterGeneratorModule } from './modules/character-generator/character-generator.module';
import { RectAngularComponent } from './components/rect-angular/rect-angular.component';
import { CaptainCanvasComponent } from './components/captain-canvas/captain-canvas.component';
import { ImageCropperComponent } from './components/image-cropper/image-cropper.component';
import { CommonModule } from '@angular/common';
import { provideHttpClient } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    RectAngularComponent,
    CaptainCanvasComponent,
    ImageCropperComponent
  ],
  imports: [
    BrowserModule,
    CommonModule,
    AppRoutingModule,
    CharacterGeneratorModule
  ],
  schemas: [CUSTOM_ELEMENTS_SCHEMA],
  providers: [provideHttpClient()],
  bootstrap: [AppComponent]
})
export class AppModule { }
