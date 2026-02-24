import { Component, ElementRef, Input, OnInit, ViewChild, AfterViewInit } from '@angular/core';

@Component({
  selector: 'app-captain-canvas',
  standalone: false,
  templateUrl: './captain-canvas.component.html',
  styleUrls: ['./captain-canvas.component.scss']
})
export class CaptainCanvasComponent implements OnInit, AfterViewInit {
  @Input() canvas?: string;
  @Input() settings?: string;
  @ViewChild('canvasEl', { static: false }) canvasRef!: ElementRef<HTMLCanvasElement>;
  canvasId: string = 'captainCanvas-' + Math.floor(Math.random() * Number.MAX_SAFE_INTEGER);

  private context: CanvasRenderingContext2D | null = null;
  private isDrawing = false;
  private brushSize = 3;
  private brushColor = '#000000';

  constructor() { }

  ngOnInit(): void {
    if (this.canvas) {
      this.canvasId = this.canvas;
    }
  }

  ngAfterViewInit(): void {
    const el = this.canvasRef?.nativeElement;
    if (el) {
      this.context = el.getContext('2d');
      el.width = el.offsetWidth || 400;
      el.height = el.offsetHeight || 300;
      if (this.context) {
        this.context.fillStyle = '#ffffff';
        this.context.fillRect(0, 0, el.width, el.height);
      }
    }
  }

  onMouseDown(event: MouseEvent): void {
    this.isDrawing = true;
    const rect = (event.target as HTMLCanvasElement).getBoundingClientRect();
    if (this.context) {
      this.context.beginPath();
      this.context.moveTo(event.clientX - rect.left, event.clientY - rect.top);
    }
  }

  onMouseMove(event: MouseEvent): void {
    if (!this.isDrawing || !this.context) { return; }
    const rect = (event.target as HTMLCanvasElement).getBoundingClientRect();
    this.context.lineWidth = this.brushSize;
    this.context.lineCap = 'round';
    this.context.strokeStyle = this.brushColor;
    this.context.lineTo(event.clientX - rect.left, event.clientY - rect.top);
    this.context.stroke();
  }

  onMouseUp(): void {
    this.isDrawing = false;
  }

  clearCanvas(): void {
    const el = this.canvasRef?.nativeElement;
    if (el && this.context) {
      this.context.fillStyle = '#ffffff';
      this.context.fillRect(0, 0, el.width, el.height);
    }
  }

  setBrushSize(size: number): void {
    this.brushSize = size;
  }

  setBrushColor(color: string): void {
    this.brushColor = color;
  }
}
