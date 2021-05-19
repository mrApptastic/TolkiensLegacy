import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { Validators, FormControl, FormGroup } from "@angular/forms";

@Component({
  selector: 'app-image-cropper',
  templateUrl: './image-cropper.component.html',
  styleUrls: ['./image-cropper.component.scss']
})

export class ImageCropperComponent implements OnInit {
  @Input() canvas?: string;
  @ViewChild("fileUploader") public fileUploader: any;
  imageForm = new FormGroup({
    name: new FormControl("", [Validators.required]),
    file: new FormControl("", [Validators.required]),
    fileSource: new FormControl("", [Validators.required])
  });
  imgInput = "imgInput-" + Math.floor(Math.random() * Number.MAX_SAFE_INTEGER);
  huhu = new Image();
  draw = false;
  resizeX = false;
  resizeY = false;
  moveCoords = [null, null, null, null];
  sliding = false;
  context: any;
  colours = new Array();

  constructor() {}

  ngOnInit(): void {
    if (!this.canvas) {
      this.canvas = "imageCropper-" + Math.floor(Math.random() * Number.MAX_SAFE_INTEGER);
    }
    setTimeout(() => {
      this.context = document.getElementById(this.canvas)['getContext']('2d');
      this.context.fillRect(5, 5, 5, 5);
    }, 0);
  }

  openFileDialog(): void {
    document.getElementById(this.imgInput).click();
  }

  upload(): void {
    const input = document.getElementById(this.imgInput)?.['files'];

    if (input && input.length > 0) {
      console.log(input[0]);
    //   const reader = new FileReader();
    //     reader.onload = (e) => {
    //     this.huhu.src = e.target.result.toString();
    //     //       document.getElementById("fileText").value = replaceInvalidCharacters(input.files[0].name.split(".")[0]);
    //     // document.getElementById('fileDescription').value = input.files[0].name.split(".")[0];
    //     // document.getElementById("fileType").value = input.files[0].name.split(".")[1];
    //     // this.context.clearRect(0,0, 200, 200);

    //     }
    //     setTimeout(this.reDrawImage,50);
    //     reader.readAsDataURL(input[0]);
    }
  }

  reDrawImage(): void {
    var scale = 1;
    var left = 0;
    var top = 0;
    setTimeout(() => {
      this.context.drawImage(this.huhu,left,top, this.huhu.width*(scale/100), this.huhu.height*(scale/100));
    }, 0);
  }

  // onDialogOKSelected(): void {
  //   const file = this.img.dataURLtoFile(this.croppedImage); // must be converted to data url
  //   if (file) {

  //     this.imageForm.patchValue({
  //       name: file.name,
  //       file: { file },
  //       fileSource: file
  //     });

  //   }
  // }

  // uploadImage(): void {

  //   const formData = new FormData();
  //   formData.append("file", this.imageForm.get("fileSource").value);

  //   this.data.upload(formData).subscribe(x => {

  //     }, e => {
  //       this.error.handleError(e);
  //     });

  // }

}
