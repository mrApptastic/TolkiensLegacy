import { Component, ElementRef, Input, OnInit, ViewChild, AfterViewInit } from '@angular/core';

@Component({
  selector: 'app-image-cropper',
  standalone: false,
  templateUrl: './image-cropper.component.html',
  styleUrls: ['./image-cropper.component.scss']
})
export class ImageCropperComponent implements OnInit, AfterViewInit {
  @Input() canvas?: string;
  @ViewChild('canvasEl', { static: false }) canvasRef!: ElementRef<HTMLCanvasElement>;
  @ViewChild('fileInput', { static: false }) fileInputRef!: ElementRef<HTMLInputElement>;
  canvasId: string = 'imageCropper-' + Math.floor(Math.random() * Number.MAX_SAFE_INTEGER);
  private context: CanvasRenderingContext2D | null = null;
  private image = new Image();

  constructor() {}

  ngOnInit(): void {
    if (this.canvas) {
      this.canvasId = this.canvas;
    }
  }

  ngAfterViewInit(): void {
    const el = this.canvasRef?.nativeElement;
    if (el) {
      el.width = el.offsetWidth || 300;
      el.height = el.offsetHeight || 200;
      this.context = el.getContext('2d');
      if (this.context) {
        this.context.fillStyle = '#f0f0f0';
        this.context.fillRect(0, 0, el.width, el.height);
        this.context.fillStyle = '#999';
        this.context.font = '14px sans-serif';
        this.context.textAlign = 'center';
        this.context.fillText('Click to upload an image', el.width / 2, el.height / 2);
      }
    }
  }

  openFileDialog(): void {
    this.fileInputRef?.nativeElement?.click();
  }

  onFileSelected(event: Event): void {
    const input = event.target as HTMLInputElement;
    if (input.files && input.files.length > 0) {
      const file = input.files[0];
      const reader = new FileReader();
      reader.onload = (e) => {
        this.image.src = (e.target?.result as string) || '';
        this.image.onload = () => this.drawImage();
      };
      reader.readAsDataURL(file);
    }
  }

  private drawImage(): void {
    const el = this.canvasRef?.nativeElement;
    if (!el || !this.context) { return; }

    // Scale image to fit canvas
    const scale = Math.min(el.width / this.image.width, el.height / this.image.height);
    const w = this.image.width * scale;
    const h = this.image.height * scale;
    const x = (el.width - w) / 2;
    const y = (el.height - h) / 2;

    this.context.clearRect(0, 0, el.width, el.height);
    this.context.fillStyle = '#f0f0f0';
    this.context.fillRect(0, 0, el.width, el.height);
    this.context.drawImage(this.image, x, y, w, h);
  }
}
