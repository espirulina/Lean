/*
 * QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
 * Lean Algorithmic Trading Engine v2.0. Copyright 2014 QuantConnect Corporation.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
*/

//------------------------------------------------------------------------------
// This code was generated by a tool.
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;

namespace QuantConnect.Data.Fundamental
{
	/// <summary>
	/// Definition of the EarningReports class
	/// </summary>
	public class EarningReports
	{
		/// <summary>
		/// The exact date that is given in the financial statements for each quarter’s end.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 20001
		/// </remarks>
		public DateTime PeriodEndingDate { get; set; }

		/// <summary>
		/// Specific date on which a company released its filing to the public.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 20002
		/// </remarks>
		public DateTime FileDate { get; set; }

		/// <summary>
		/// The accession number is a unique number that EDGAR assigns to each submission as the submission is received.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 20003
		/// </remarks>
		public string AccessionNumber { get; set; }

		/// <summary>
		/// The type of filing of the report: for instance, 10-K (annual report) or 10-Q (quarterly report).
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 20004
		/// </remarks>
		public string FormType { get; set; }

		/// <summary>
		/// Basic EPS from Continuing Operations is the earnings from continuing operations reported by the company divided by the weighted
		/// average number of common shares outstanding.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 29000
		/// </remarks>
		public BasicContinuousOperations BasicContinuousOperations { get; set; }

		/// <summary>
		/// Basic EPS from Discontinued Operations is the earnings from discontinued operations reported by the company divided by the
		/// weighted average number of common shares outstanding. This only includes gain or loss from discontinued operations.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 29001
		/// </remarks>
		public BasicDiscontinuousOperations BasicDiscontinuousOperations { get; set; }

		/// <summary>
		/// Basic EPS from the Extraordinary Gains/Losses is the earnings attributable to the gains or losses (during the reporting period) from
		/// extraordinary items divided by the weighted average number of common shares outstanding.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 29002
		/// </remarks>
		public BasicExtraordinary BasicExtraordinary { get; set; }

		/// <summary>
		/// Basic EPS from the Cumulative Effect of Accounting Change is the earnings attributable to the accounting change (during the
		/// reporting period) divided by the weighted average number of common shares outstanding.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 29003
		/// </remarks>
		public BasicAccountingChange BasicAccountingChange { get; set; }

		/// <summary>
		/// Basic EPS is the bottom line net income divided by the weighted average number of common shares outstanding.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 29004
		/// </remarks>
		public BasicEPS BasicEPS { get; set; }

		/// <summary>
		/// Diluted EPS from Continuing Operations is the earnings from continuing operations divided by the common shares outstanding
		/// adjusted for the assumed conversion of all potentially dilutive securities.  Securities having a dilutive effect may include convertible
		/// debentures, warrants, options, and convertible preferred stock.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 29005
		/// </remarks>
		public DilutedContinuousOperations DilutedContinuousOperations { get; set; }

		/// <summary>
		/// Diluted EPS from Discontinued Operations is the earnings from discontinued operations divided by the common shares outstanding
		/// adjusted for the assumed conversion of all potentially dilutive securities. Securities having a dilutive effect may include convertible
		/// debentures, warrants, options, and convertible preferred stock. This only includes gain or loss from discontinued operations.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 29006
		/// </remarks>
		public DilutedDiscontinuousOperations DilutedDiscontinuousOperations { get; set; }

		/// <summary>
		/// Diluted EPS from Extraordinary Gain/Losses is the gain or loss from extraordinary items divided by the common shares outstanding
		/// adjusted for the assumed conversion of all potentially dilutive securities. Securities having a dilutive effect may include convertible
		/// debentures, warrants, options, and convertible preferred stock.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 29007
		/// </remarks>
		public DilutedExtraordinary DilutedExtraordinary { get; set; }

		/// <summary>
		/// Diluted EPS from Cumulative Effect Accounting Changes is the earnings from accounting changes (in the reporting period) divided
		/// by the common shares outstanding adjusted for the assumed conversion of all potentially dilutive securities. Securities having a
		/// dilutive effect may include convertible debentures, warrants, options, and convertible preferred stock.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 29008
		/// </remarks>
		public DilutedAccountingChange DilutedAccountingChange { get; set; }

		/// <summary>
		/// Diluted EPS is the bottom line net income divided by the common shares outstanding adjusted for the assumed conversion of all
		/// potentially dilutive securities. Securities having a dilutive effect may include convertible debentures, warrants, options, and
		/// convertible preferred stock. This value will be derived when not reported for the fourth quarter and will be less than or equal to
		/// Basic EPS.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 29009
		/// </remarks>
		public DilutedEPS DilutedEPS { get; set; }

		/// <summary>
		/// The shares outstanding used to calculate Basic EPS, which is the weighted average common share outstanding through the whole
		/// accounting period.  Note: If Basic Average Shares are not presented by the firm in the Income Statement, this data point will be
		/// null.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 29010
		/// </remarks>
		public BasicAverageShares BasicAverageShares { get; set; }

		/// <summary>
		/// The shares outstanding used to calculate the diluted EPS, assuming the conversion of all convertible securities and the exercise of
		/// warrants or stock options. It is the weighted average diluted share outstanding through the whole accounting period.  Note: If
		/// Diluted Average Shares are not presented by the firm in the Income Statement and Basic Average Shares are presented, Diluted
		/// Average Shares will equal Basic Average Shares.  However, if neither value is presented by the firm, Diluted Average Shares will be
		/// null.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 29011
		/// </remarks>
		public DilutedAverageShares DilutedAverageShares { get; set; }

		/// <summary>
		/// The amount of dividend that a stockholder will receive for each share of stock held. It can be calculated by taking the total amount
		/// of dividends paid and dividing it by the total shares outstanding. Dividend per share = total dividend payment/total number of
		/// outstanding shares
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 29012
		/// </remarks>
		public DividendPerShare DividendPerShare { get; set; }

		/// <summary>
		/// Basic EPS from the Other Gains/Losses is the earnings attributable to the other gains/losses (during the reporting period) divided by
		/// the weighted average number of common shares outstanding.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 29013
		/// </remarks>
		public BasicEPSOtherGainsLosses BasicEPSOtherGainsLosses { get; set; }

		/// <summary>
		/// Basic EPS from Continuing Operations plus Basic EPS from Discontinued Operations.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 29014
		/// </remarks>
		public ContinuingAndDiscontinuedBasicEPS ContinuingAndDiscontinuedBasicEPS { get; set; }

		/// <summary>
		/// The earnings attributable to the tax loss carry forward (during the reporting period).
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 29015
		/// </remarks>
		public TaxLossCarryforwardBasicEPS TaxLossCarryforwardBasicEPS { get; set; }

		/// <summary>
		/// The earnings from gains and losses (in the reporting period) divided by the common shares outstanding adjusted for the assumed
		/// conversion of all potentially dilutive securities. Securities having a dilutive effect may include convertible debentures, warrants,
		/// options, convertible preferred stock, etc.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 29016
		/// </remarks>
		public DilutedEPSOtherGainsLosses DilutedEPSOtherGainsLosses { get; set; }

		/// <summary>
		/// Diluted EPS from Continuing Operations plus Diluted EPS from Discontinued Operations.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 29017
		/// </remarks>
		public ContinuingAndDiscontinuedDilutedEPS ContinuingAndDiscontinuedDilutedEPS { get; set; }

		/// <summary>
		/// The earnings from any tax loss carry forward (in the reporting period).
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 29018
		/// </remarks>
		public TaxLossCarryforwardDilutedEPS TaxLossCarryforwardDilutedEPS { get; set; }

		/// <summary>
		/// The basic normalized earnings per share. Normalized EPS removes onetime and unusual items from EPS, to provide investors with a
		/// more accurate measure of the company’s true earnings. Normalized Earnings / Basic Weighted Average Shares Outstanding.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 29019
		/// </remarks>
		public NormalizedBasicEPS NormalizedBasicEPS { get; set; }

		/// <summary>
		/// The diluted normalized earnings per share. Normalized EPS removes onetime and unusual items from EPS, to provide investors with
		/// a more accurate measure of the company’s true earnings. Normalized Earnings / Diluted Weighted Average Shares Outstanding.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 29020
		/// </remarks>
		public NormalizedDilutedEPS NormalizedDilutedEPS { get; set; }

		/// <summary>
		/// Total Dividend Per Share is cash dividends and special cash dividends paid per share over a certain period of time
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 29021
		/// </remarks>
		public TotalDividendPerShare TotalDividendPerShare { get; set; }

		/// <summary>
		/// Creates an instance of the EarningReports class
		/// </summary>
		public EarningReports()
		{
			BasicContinuousOperations = new BasicContinuousOperations();
			BasicDiscontinuousOperations = new BasicDiscontinuousOperations();
			BasicExtraordinary = new BasicExtraordinary();
			BasicAccountingChange = new BasicAccountingChange();
			BasicEPS = new BasicEPS();
			DilutedContinuousOperations = new DilutedContinuousOperations();
			DilutedDiscontinuousOperations = new DilutedDiscontinuousOperations();
			DilutedExtraordinary = new DilutedExtraordinary();
			DilutedAccountingChange = new DilutedAccountingChange();
			DilutedEPS = new DilutedEPS();
			BasicAverageShares = new BasicAverageShares();
			DilutedAverageShares = new DilutedAverageShares();
			DividendPerShare = new DividendPerShare();
			BasicEPSOtherGainsLosses = new BasicEPSOtherGainsLosses();
			ContinuingAndDiscontinuedBasicEPS = new ContinuingAndDiscontinuedBasicEPS();
			TaxLossCarryforwardBasicEPS = new TaxLossCarryforwardBasicEPS();
			DilutedEPSOtherGainsLosses = new DilutedEPSOtherGainsLosses();
			ContinuingAndDiscontinuedDilutedEPS = new ContinuingAndDiscontinuedDilutedEPS();
			TaxLossCarryforwardDilutedEPS = new TaxLossCarryforwardDilutedEPS();
			NormalizedBasicEPS = new NormalizedBasicEPS();
			NormalizedDilutedEPS = new NormalizedDilutedEPS();
			TotalDividendPerShare = new TotalDividendPerShare();
		}

		/// <summary>
		/// Sets values for non existing periods from a previous instance
		/// </summary>
		/// <remarks>Used to fill-forward values from previous dates</remarks>
		/// <param name="previous">The previous instance</param>
		public void UpdateValues(EarningReports previous)
		{
			BasicContinuousOperations.UpdateValues(previous.BasicContinuousOperations);
			BasicDiscontinuousOperations.UpdateValues(previous.BasicDiscontinuousOperations);
			BasicExtraordinary.UpdateValues(previous.BasicExtraordinary);
			BasicAccountingChange.UpdateValues(previous.BasicAccountingChange);
			BasicEPS.UpdateValues(previous.BasicEPS);
			DilutedContinuousOperations.UpdateValues(previous.DilutedContinuousOperations);
			DilutedDiscontinuousOperations.UpdateValues(previous.DilutedDiscontinuousOperations);
			DilutedExtraordinary.UpdateValues(previous.DilutedExtraordinary);
			DilutedAccountingChange.UpdateValues(previous.DilutedAccountingChange);
			DilutedEPS.UpdateValues(previous.DilutedEPS);
			BasicAverageShares.UpdateValues(previous.BasicAverageShares);
			DilutedAverageShares.UpdateValues(previous.DilutedAverageShares);
			DividendPerShare.UpdateValues(previous.DividendPerShare);
			BasicEPSOtherGainsLosses.UpdateValues(previous.BasicEPSOtherGainsLosses);
			ContinuingAndDiscontinuedBasicEPS.UpdateValues(previous.ContinuingAndDiscontinuedBasicEPS);
			TaxLossCarryforwardBasicEPS.UpdateValues(previous.TaxLossCarryforwardBasicEPS);
			DilutedEPSOtherGainsLosses.UpdateValues(previous.DilutedEPSOtherGainsLosses);
			ContinuingAndDiscontinuedDilutedEPS.UpdateValues(previous.ContinuingAndDiscontinuedDilutedEPS);
			TaxLossCarryforwardDilutedEPS.UpdateValues(previous.TaxLossCarryforwardDilutedEPS);
			NormalizedBasicEPS.UpdateValues(previous.NormalizedBasicEPS);
			NormalizedDilutedEPS.UpdateValues(previous.NormalizedDilutedEPS);
			TotalDividendPerShare.UpdateValues(previous.TotalDividendPerShare);
		}
	}
}