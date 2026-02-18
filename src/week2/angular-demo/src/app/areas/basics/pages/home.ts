import { Component, ChangeDetectionStrategy } from '@angular/core';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-basics-home',
  changeDetection: ChangeDetectionStrategy.OnPush,
  imports: [RouterOutlet],
  template: `
    <div class="flex flex-col items-center justify-center gap-4">
      <h2 class="text-2xl font-bold">Basic Stuff You Should Know About Angular</h2>
    </div>
    <router-outlet></router-outlet>
  `,
  styles: ``,
})
export class HomePage {}
