import { CUSTOM_ELEMENTS_SCHEMA, NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CharacterGeneratorModule } from './modules/character-generator/character-generator.module';
import { MrMr2Module } from 'mr-mr2';
import { RectAngularComponent } from './components/rect-angular/rect-angular.component';
import { CaptainCanvasComponent } from './components/captain-canvas/captain-canvas.component';
import { ImageCropperComponent } from './components/image-cropper/image-cropper.component';

@NgModule({
  declarations: [
    AppComponent,
    RectAngularComponent,
    CaptainCanvasComponent,
    ImageCropperComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    CharacterGeneratorModule,
    MrMr2Module
  ],
  schemas: [CUSTOM_ELEMENTS_SCHEMA],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
