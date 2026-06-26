@import url('https://fonts.googleapis.com/css2?family=Inter:wght@400;500;600;700;800;900&display=swap');

/* ── CSS Custom Properties ── */
:root {
  --navy:    #14304f;
  --navy-2:  #1e4a73;
  --navy-3:  #2d6aad;
  --navy-lt: #e8f0f9;
  --bg:      #f0f4f9;
  --panel:   #ffffff;
  --line:    #dde4ed;
  --text:    #0f1e2e;
  --muted:   #5c6d82;
  --c-full:  #2a7a22;
  --c-upd:   #8a5200;
  --c-miss:  #b02020;
  --c-none:  #5a5e64;
  --shadow-sm: 0 1px 3px rgba(14,28,46,0.08), 0 4px 14px rgba(14,28,46,0.06);
  --shadow-md: 0 4px 20px rgba(14,28,46,0.10), 0 1px 4px rgba(14,28,46,0.06);
  --r-lg: 20px;
  --r-md: 14px;
  --r-sm: 10px;
  --font: 'Inter', ui-sans-serif, system-ui, -apple-system, sans-serif;
}

/* ── Reset ── */
*, *::before, *::after {
  box-sizing: border-box;
  margin: 0;
  padding: 0;
}

html {
  scroll-behavior: smooth;
}

body {
  font-family: var(--font);
  color: var(--text);
  background: var(--bg);
  min-height: 100vh;
  padding: 20px;
}

/* ── Page shell ── */
.page {
  max-width: 1480px;
  margin: 0 auto;
  display: flex;
  flex-direction: column;
  gap: 14px;
}

/* ── Hero ── */
.hero {
  background: linear-gradient(118deg, #0f2440 0%, #1a3d68 55%, #1e5090 100%);
  border-radius: var(--r-lg);
  padding: 28px 32px 24px;
  color: #f0f6ff;
  position: relative;
  overflow: hidden;
  box-shadow: 0 8px 32px rgba(10,22,42,0.28);
}

.hero::before {
  content: '';
  position: absolute;
  top: -60px;
  right: -60px;
  width: 320px;
  height: 320px;
  border-radius: 50%;
  background: radial-gradient(circle, rgba(255,255,255,0.08) 0%, transparent 70%);
  pointer-events: none;
}

.hero::after {
  content: '';
  position: absolute;
  bottom: 0;
  left: 0;
  right: 0;
  height: 2px;
  background: linear-gradient(90deg, transparent, rgba(100,160,255,0.4), transparent);
}

.hero-body {
  display: flex;
  align-items: flex-start;
  justify-content: space-between;
  gap: 24px;
  flex-wrap: wrap;
}

.hero-left {
  flex: 1;
  min-width: 260px;
}

.hero-eyebrow {
  display: inline-flex;
  align-items: center;
  gap: 6px;
  font-size: 11px;
  font-weight: 700;
  letter-spacing: 0.13em;
  text-transform: uppercase;
  color: rgba(180,210,255,0.85);
  margin-bottom: 10px;
}

.hero-eyebrow::before {
  content: '';
  width: 20px;
  height: 1.5px;
  background: rgba(180,210,255,0.5);
}

.hero h1 {
  font-size: clamp(22px, 2.6vw, 36px);
  font-weight: 800;
  letter-spacing: -0.03em;
  line-height: 1.1;
  margin-bottom: 8px;
  color: #ffffff;
}

.hero p {
  font-size: 14px;
  line-height: 1.6;
  color: rgba(220,235,255,0.82);
  max-width: 600px;
}

.hero-stats {
  display: flex;
  gap: 10px;
  flex-wrap: wrap;
  align-self: flex-start;
  padding-top: 4px;
}

.hero-kpi {
  background: rgba(255,255,255,0.09);
  border: 1px solid rgba(255,255,255,0.13);
  border-radius: 14px;
  padding: 12px 16px;
  min-width: 110px;
  backdrop-filter: blur(8px);
}

.hero-kpi-label {
  font-size: 11px;
  color: rgba(200,220,255,0.72);
  margin-bottom: 3px;
}

.hero-kpi-value {
  font-size: 22px;
  font-weight: 800;
  letter-spacing: -0.03em;
  color: #fff;
}

/* ── Main panel ── */
.panel {
  background: var(--panel);
  border: 1px solid var(--line);
  border-radius: var(--r-lg);
  box-shadow: var(--shadow-md);
  overflow: hidden;
  border-top: 4px solid var(--navy);
}

.panel-inner {
  padding: 18px 20px;
}

/* ── Stat strip ── */
.stats {
  display: grid;
  grid-template-columns: repeat(4, 1fr);
  gap: 10px;
  margin-bottom: 16px;
}

.stat {
  border-radius: var(--r-md);
  padding: 13px 15px;
  border: 1px solid var(--line);
  background: #fafcff;
  display: flex;
  flex-direction: column;
  gap: 3px;
  border-left-width: 3px;
}

.stat-total  { border-left-color: var(--navy-3); }
.stat-full   { border-left-color: var(--c-full); }
.stat-upd    { border-left-color: var(--c-upd); }
.stat-issues { border-left-color: var(--c-miss); }

.stat-label {
  font-size: 11px;
  font-weight: 600;
  color: var(--muted);
  text-transform: uppercase;
  letter-spacing: 0.05em;
}

.stat-val {
  font-size: 26px;
  font-weight: 800;
  letter-spacing: -0.04em;
  line-height: 1;
}

.stat-total  .stat-val { color: var(--navy); }
.stat-full   .stat-val { color: var(--c-full); }
.stat-upd    .stat-val { color: var(--c-upd); }
.stat-issues .stat-val { color: var(--c-miss); }

/* ── Controls row ── */
.controls {
  display: flex;
  gap: 10px;
  align-items: center;
  flex-wrap: wrap;
  margin-bottom: 14px;
  padding-bottom: 14px;
  border-bottom: 1px solid var(--line);
}

.search-wrap {
  position: relative;
  flex: 1;
  min-width: 220px;
}

.search-wrap svg {
  position: absolute;
  left: 12px;
  top: 50%;
  transform: translateY(-50%);
  width: 15px;
  height: 15px;
  color: var(--muted);
  pointer-events: none;
}

.controls input {
  width: 100%;
  height: 40px;
  padding: 0 14px 0 36px;
  border: 1px solid var(--line);
  border-radius: var(--r-sm);
  font-family: var(--font);
  font-size: 13.5px;
  color: var(--text);
  background: #f7fafc;
  outline: none;
  transition: border-color 0.15s, box-shadow 0.15s;
}

.controls input:focus {
  border-color: var(--navy-3);
  background: #fff;
  box-shadow: 0 0 0 3px rgba(45,106,173,0.12);
}

.controls select {
  height: 40px;
  padding: 0 30px 0 12px;
  border: 1px solid var(--line);
  border-radius: var(--r-sm);
  font-family: var(--font);
  font-size: 13.5px;
  color: var(--text);
  background: #f7fafc url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' width='12' height='8' viewBox='0 0 12 8'%3E%3Cpath d='M1 1l5 5 5-5' stroke='%235c6d82' stroke-width='1.5' fill='none' stroke-linecap='round'/%3E%3C/svg%3E") no-repeat right 10px center;
  appearance: none;
  outline: none;
  cursor: pointer;
  transition: border-color 0.15s, box-shadow 0.15s;
  white-space: nowrap;
}

.controls select:focus {
  border-color: var(--navy-3);
  background-color: #fff;
  box-shadow: 0 0 0 3px rgba(45,106,173,0.12);
}

.btn-reset {
  height: 40px;
  padding: 0 16px;
  border: 1px solid var(--line);
  border-radius: var(--r-sm);
  background: #f7fafc;
  color: var(--muted);
  font-family: var(--font);
  font-size: 13px;
  font-weight: 600;
  cursor: pointer;
  white-space: nowrap;
  transition: background 0.12s, color 0.12s, border-color 0.12s;
}

.btn-reset:hover {
  background: #fff;
  color: var(--navy);
  border-color: var(--navy-3);
}

/* ── Legend ── */
.legend {
  display: flex;
  gap: 16px;
  flex-wrap: wrap;
  align-items: center;
  font-size: 12px;
  color: var(--muted);
  margin-bottom: 14px;
}

.legend-item {
  display: flex;
  align-items: center;
  gap: 6px;
}

.dot {
  width: 9px;
  height: 9px;
  border-radius: 50%;
  flex-shrink: 0;
}

/* ── Table ── */
.tbl-wrap {
  overflow-x: auto;
  border-radius: var(--r-md);
  border: 1px solid var(--line);
}

table {
  width: 100%;
  border-collapse: collapse;
  font-size: 13px;
}

thead th {
  background: #f2f6fb;
  padding: 11px 13px;
  text-align: left;
  font-size: 11.5px;
  font-weight: 700;
  color: #4a5e74;
  border-bottom: 1px solid var(--line);
  white-space: nowrap;
  position: sticky;
  top: 0;
  z-index: 2;
  cursor: pointer;
  user-select: none;
  transition: color 0.1s;
}

thead th:hover { color: var(--navy); }

thead th .arr {
  font-size: 9px;
  margin-left: 3px;
  opacity: 0.45;
}

thead th.sorted .arr {
  opacity: 1;
  color: var(--navy-3);
}

thead th.num-head { text-align: center; }

tbody tr {
  border-bottom: 1px solid #edf1f7;
  transition: background 0.1s;
}

tbody tr:last-child { border-bottom: none; }

/* ── Status row tints ── */
tr.rs-full     { background: linear-gradient(90deg, rgba(42,122,34,0.09) 0%, transparent 35%); }
tr.rs-updated  { background: linear-gradient(90deg, rgba(138,82,0,0.08) 0%, transparent 35%); }
tr.rs-missing  { background: linear-gradient(90deg, rgba(176,32,32,0.08) 0%, transparent 35%); }
tr.rs-notfound { background: linear-gradient(90deg, rgba(90,94,100,0.07) 0%, transparent 35%); }

tr.rs-full:hover     { background: linear-gradient(90deg, rgba(42,122,34,0.14) 0%, #f4f8ff 35%); }
tr.rs-updated:hover  { background: linear-gradient(90deg, rgba(138,82,0,0.13) 0%, #f4f8ff 35%); }
tr.rs-missing:hover  { background: linear-gradient(90deg, rgba(176,32,32,0.13) 0%, #f4f8ff 35%); }
tr.rs-notfound:hover { background: linear-gradient(90deg, rgba(90,94,100,0.12) 0%, #f4f8ff 35%); }

/* ── Left accent stripes ── */
tr.rs-full td:first-child     { box-shadow: inset 4px 0 0 var(--c-full); }
tr.rs-updated td:first-child  { box-shadow: inset 4px 0 0 var(--c-upd); }
tr.rs-missing td:first-child  { box-shadow: inset 4px 0 0 var(--c-miss); }
tr.rs-notfound td:first-child { box-shadow: inset 4px 0 0 var(--c-none); }

tbody td {
  padding: 10px 13px;
  vertical-align: middle;
  overflow: hidden;
  text-overflow: ellipsis;
  white-space: nowrap;
  color: var(--text);
}

.num-cell {
  text-align: center;
  font-weight: 700;
  color: var(--navy);
  font-size: 12px;
}

.entity-cell { font-weight: 600; }

.chevron {
  font-size: 10px;
  color: var(--muted);
  margin-left: 6px;
  display: inline-block;
  transition: transform 0.18s;
}

.row-open .chevron { transform: rotate(90deg); }

/* ── Badges ── */
.badge {
  display: inline-flex;
  align-items: center;
  gap: 5px;
  font-size: 11.5px;
  font-weight: 700;
  padding: 4px 11px;
  border-radius: 999px;
  letter-spacing: 0.01em;
  white-space: nowrap;
}

.badge-green { background: #d4edcf; color: #1e5418; border: 1px solid rgba(42,122,34,0.2); }
.badge-amber { background: #f5e3c0; color: #6b3900; border: 1px solid rgba(138,82,0,0.2); }
.badge-red   { background: #fad4d4; color: #8a1515; border: 1px solid rgba(176,32,32,0.2); }
.badge-gray  { background: #e2e4e8; color: #3a3f4a; border: 1px solid rgba(90,94,100,0.2); }

/* ── Group rows ── */
.group-row td {
  background: linear-gradient(90deg, #e8eef7, #eef3f9);
  font-size: 11px;
  font-weight: 800;
  color: #2b4a72;
  letter-spacing: 0.07em;
  text-transform: uppercase;
  padding: 7px 13px;
  border-bottom: 1px solid var(--line);
}

.group-icon {
  margin-right: 6px;
  opacity: 0.6;
  font-size: 10px;
}

/* ── Expand / detail row ── */
.detail-row { display: none; }
.detail-row.open { display: table-row; }
.detail-row td { padding: 0; }

.detail-inner {
  padding: 16px 20px;
  background: linear-gradient(180deg, #f8fbff, #eef3f9);
  border-top: 1px solid var(--line);
  display: grid;
  grid-template-columns: 1fr 1fr 1fr;
  gap: 18px;
  font-size: 13px;
}

.detail-inner.dr-full     { border-left: 4px solid var(--c-full); }
.detail-inner.dr-updated  { border-left: 4px solid var(--c-upd); }
.detail-inner.dr-missing  { border-left: 4px solid var(--c-miss); }
.detail-inner.dr-notfound { border-left: 4px solid var(--c-none); }

.detail-section h4 {
  font-size: 10.5px;
  font-weight: 800;
  color: var(--muted);
  text-transform: uppercase;
  letter-spacing: 0.09em;
  margin-bottom: 10px;
  padding-bottom: 6px;
  border-bottom: 1px solid var(--line);
}

.kv { display: flex; flex-direction: column; gap: 6px; }

.kv-row {
  display: flex;
  gap: 8px;
  align-items: baseline;
  font-size: 13px;
}

.kv-key {
  color: var(--muted);
  min-width: 104px;
  flex-shrink: 0;
  font-size: 12px;
}

.kv-val {
  color: var(--text);
  word-break: break-word;
}

.kv-mono {
  font-family: 'SF Mono', 'Fira Code', monospace;
  font-size: 12px;
  color: #1a3a60;
}

/* ── Bottom bar ── */
.bottom-bar {
  display: flex;
  justify-content: space-between;
  align-items: center;
  padding: 10px 20px;
  border-top: 1px solid var(--line);
  background: #f8fafc;
  font-size: 12px;
  color: var(--muted);
}

/* ── Empty state ── */
.empty {
  text-align: center;
  padding: 40px;
  color: var(--muted);
  font-size: 14px;
}

.empty strong {
  display: block;
  font-size: 16px;
  font-weight: 700;
  color: var(--text);
  margin-bottom: 4px;
}

/* ── Responsive ── */
@media (max-width: 900px) {
  .stats        { grid-template-columns: repeat(2, 1fr); }
  .detail-inner { grid-template-columns: 1fr 1fr; }
}

@media (max-width: 600px) {
  body          { padding: 12px; }
  .stats        { grid-template-columns: 1fr 1fr; }
  .detail-inner { grid-template-columns: 1fr; }
  .hero         { padding: 20px; }
  .hero-stats   { width: 100%; }
}