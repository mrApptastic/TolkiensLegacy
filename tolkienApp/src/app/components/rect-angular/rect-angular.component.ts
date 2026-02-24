import { Component, ElementRef, Input, OnInit, ViewChild, AfterViewInit } from '@angular/core';

@Component({
  selector: 'app-rect-angular',
  standalone: false,
  templateUrl: './rect-angular.component.html',
  styleUrls: ['./rect-angular.component.scss']
})
export class RectAngularComponent implements OnInit, AfterViewInit {
  @Input() canvas?: string;
  @Input() width?: number;
  @Input() height?: number;
  @Input() heading?: number;
  @Input() colour?: string;
  @Input() font?: string;
  @ViewChild('canvasEl', { static: false }) canvasRef!: ElementRef<HTMLCanvasElement>;
  canvasId: string = 'rectAngular-' + Math.floor(Math.random() * Number.MAX_SAFE_INTEGER);

  private context: CanvasRenderingContext2D | null = null;

  constructor() { }

  ngOnInit(): void {
    if (this.canvas) {
      this.canvasId = this.canvas;
    }
  }

  ngAfterViewInit(): void {
    const el = this.canvasRef?.nativeElement;
    if (el) {
      el.width = this.width || el.offsetWidth || 300;
      el.height = this.height || el.offsetHeight || 150;
      this.context = el.getContext('2d');
      this.draw();
    }
  }

  draw(): void {
    if (!this.context) { return; }
    const el = this.canvasRef.nativeElement;
    const w = el.width;
    const h = el.height;

    // Fill background
    this.context.fillStyle = this.colour || '#2c3e50';
    this.context.fillRect(0, 0, w, h);

    // Draw border
    this.context.strokeStyle = '#ffffff';
    this.context.lineWidth = 2;
    this.context.strokeRect(2, 2, w - 4, h - 4);

    // Draw heading text if provided
    if (this.heading !== undefined) {
      this.context.fillStyle = '#ffffff';
      this.context.font = this.font || '16px sans-serif';
      this.context.textAlign = 'center';
      this.context.textBaseline = 'middle';
      this.context.fillText(String(this.heading), w / 2, h / 2);
    }
  }
}
